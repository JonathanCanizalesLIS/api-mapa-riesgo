namespace MapaRiesgo.API.Services
{
    public class UnidadSyncService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<UnidadSyncService> _logger;

        public UnidadSyncService(IServiceScopeFactory scopeFactory, ILogger<UnidadSyncService> logger)
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
                        var unidadBusiness = scope.ServiceProvider
                            .GetRequiredService<MapaRiesgo.API.BusinessLogic.UnidadBusiness>();

                        var response = unidadBusiness.SincronizacionUnidades();

                        _logger.LogInformation($"Sincronización ejecutada: {response.Message}");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error en sincronización automática");
                }

                await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
            }
        }
    }
}