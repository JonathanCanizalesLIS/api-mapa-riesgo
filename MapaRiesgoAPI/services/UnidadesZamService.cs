using MapaRiesgo.API.BusinessLogic;
using MapaRiesgo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace MapaRiesgo.API.services
{
    public class UnidadesZamService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<UnidadesZamService> _logger;

        public UnidadesZamService(IServiceScopeFactory scopeFactory, ILogger<UnidadesZamService> logger)
        {
            _scopeFactory = scopeFactory;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Servicio de sincronización iniciado.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _scopeFactory.CreateScope())
                    {
                        var myService = scope.ServiceProvider.GetRequiredService<UnidadZamBusiness>();
                        var myService2 = scope.ServiceProvider.GetRequiredService<EmpresasBDConexionBusiness>();
                        var controller = new Controllers.UnidadesZAMController(myService2, myService);

                        var response = controller.GetPosicionUnidades(); ;

                        _logger.LogInformation($"Sincronización ejecutada");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error en sincronización automática");
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
