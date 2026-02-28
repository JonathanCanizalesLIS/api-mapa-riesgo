using MapaRiesgo.API.Services;

namespace MapaRiesgo.API.services
{
    public class UnidadesZamService: BackgroundService
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
                        var unidadZam = scope.ServiceProvider
                            .GetRequiredService<MapaRiesgo.API.Controllers.UnidadesZAMController>();

                        var response = unidadZam.GetPosicionUnidades();

                        _logger.LogInformation($"Sincronización ejecutada");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error en sincronización automática");
                }

                await Task.Delay(TimeSpan.FromMinutes(10), stoppingToken);
            }
        }
    }
}
