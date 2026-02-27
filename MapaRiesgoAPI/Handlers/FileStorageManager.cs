using Renci.SshNet;
using System.Diagnostics;

namespace ElectronicDataInterchange.API.Handlers
{
    public class FileStorageManager
    {
        private readonly IConfiguration _configuration;
        private string _host, _username, _password;
        private int _port, _filesizelimit;

        public File Archivo;


        public class File
        {
            public string Nombre { get; set; }
            public string Temp { get; set; }
            public string Ruta { get; set; }
            public string Tipo { get; set; }
            public long Tamaño { get; set; }

            public void BorrarArchivoTemporal()
            {
                if (Ruta != null)
                    System.IO.File.Delete(Ruta);

            }

        }

        public FileStorageManager(IConfiguration configuration)
        {
            _configuration = configuration;
            _host = _configuration["AzureBlobStorage:Host"];
            _port = int.Parse(_configuration["AzureBlobStorage:Port"]);
            _username = _configuration["AzureBlobStorage:UserName"];
            _password = _configuration["AzureBlobStorage:Password"];
            _filesizelimit = int.Parse(_configuration["AzureBlobStorage:FileSizeLimit"]);

            Archivo = new File();
        }

        public void FileUploadSFTP(IFormFile file, string path, string? name = null)
        {
            Archivo.Nombre = name ?? file.FileName;
            Archivo.Tamaño = file.Length;
            Archivo.Tipo = file.ContentType;

            if (Archivo.Tamaño > _filesizelimit)
                throw new Exception($"El tamaño de archivo máximo permitido es {_filesizelimit} bytes");

            using (var client = new SftpClient(_host, _port, _username, _password))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    Debug.WriteLine("Conectado al cliente SFTP");

                    using (var ms = file.OpenReadStream())
                    {
                        if (!client.Exists(path))
                            client.CreateDirectory(path);

                        //client.BufferSize = (uint)ms.Length; // bypass Payload error large files
                        client.UploadFile(ms, $"{path}/{Archivo.Nombre}");
                    }
                }
                else
                {
                    throw new Exception("Error en la conexión");
                }
            }
        }


        public bool FileDownloadSFTP(string path)
        {
            var tempDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Assets/Temporal/Files");

            Archivo.Temp = DateTime.Now.Ticks.ToString();
            Archivo.Ruta = Path.Combine(tempDir, Archivo.Temp);

            if (!Directory.Exists(tempDir))
                Directory.CreateDirectory(tempDir);

            using (var client = new SftpClient(_host, _port, _username, _password))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    Debug.WriteLine("Conectado al cliente SFTP");

                    if (!client.Exists(path))
                        throw new Exception($"El archivo no se encuentra en la ruta especificada: {path}.");

                    using (Stream fileStream = System.IO.File.Create(Archivo.Ruta))
                    {
                        client.DownloadFile(path, fileStream);
                        var file = client.Get(path);

                        Archivo.Nombre = file.Name;
                        Archivo.Tamaño = fileStream.Length;
                        Archivo.Tipo = file.Name.Split('.').Last().GetMimeType();

                    }
                }
                else
                {
                    throw new Exception("Error en la conexión");
                }
            }
            return true;
        }

    }
}
