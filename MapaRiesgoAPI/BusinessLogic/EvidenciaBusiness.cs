using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Classes.Modelo;
using ElectronicDataInterchange.API.Constants;
using MapaRiesgo.DL.Models;
using Microsoft.EntityFrameworkCore;

namespace MapaRiesgo.API.BusinessLogic
{
    public class EvidenciaBusiness : Base
    {
        public EvidenciaBusiness(
            MapaRiesgoContext mapaRiesgoContext,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor
        ) : base(configuration, httpContextAccessor, mapaRiesgoContext)
        {
        }

        /// <summary>
        /// Guarda una evidencia en la tabla evento (modelo simplificado)
        /// </summary>
        /// <param name="evidencia">Datos de la evidencia a guardar</param>
        /// <returns>Respuesta con el ID del evento generado</returns>
        public Response<EvidenciaGuardarResponse> GuardarEvidencia(EvidenciaGuardarRequest evidencia)
        {
            try
            {
                // Crear el evento
                var evento = new Evento
                {
                    IdTipoEvento = string.IsNullOrEmpty(evidencia.TipoFoto) ? 1 : int.Parse(evidencia.TipoFoto),
                    Latitud = (decimal)evidencia.Latitud,
                    Longitud = (decimal)evidencia.Longitud,
                    Evidencia = evidencia.NombreFoto,
                    Fecha = DateTime.Now,
                    IdSistemaOrigen = (int)SistemaEnumerable.Sistema.LISTMS,
                    IdEmpresa = evidencia.IdEmpresa
                };

                // Guardar en la base de datos usando el contexto de la clase Base
                MapaRiesgoContext.Eventos.Add(evento);
                MapaRiesgoContext.SaveChanges();

                var response = new EvidenciaGuardarResponse
                {
                    IdEvento = evento.IdEvento,
                    NombreFoto = evidencia.NombreFoto,
                    Latitud = evidencia.Latitud,
                    Longitud = evidencia.Longitud,
                    Fecha = evento.Fecha
                };

                return new Response<EvidenciaGuardarResponse>
                {
                    Id = evento.IdEvento,
                    Status = StatusCodes.Status200OK,
                    Message = "Evidencia guardada exitosamente",
                    HasError = false,
                    Data = response
                };
            }
            catch (Exception ex)
            {
                return new Response<EvidenciaGuardarResponse>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al guardar la evidencia: {ex.Message}",
                    HasError = true,
                    Data = null
                };
            }
        }

        /// <summary>
        /// Guarda una evidencia en la tabla evento
        /// </summary>
        /// <param name="evidencia">Datos de la evidencia a guardar</param>
        /// <returns>Respuesta con el ID del evento generado</returns>
        public Response<EvidenciaRequest> GuardarEvidencia(EvidenciaRequest evidencia)
        {
            try
            {
                // Crear el evento
                var evento = new Evento
                {
                    IdTipoEvento = string.IsNullOrEmpty(evidencia.TipoFoto) ? 1 : int.Parse(evidencia.TipoFoto),
                    Latitud = (decimal)evidencia.Latitud,
                    Longitud = (decimal)evidencia.Longitud,
                    Evidencia = evidencia.NombreFoto,
                    Fecha = DateTime.Now,
                    IdSistemaOrigen = (int)SistemaEnumerable.Sistema.LISTMS,
                    IdEmpresa = evidencia.IdEmpresa
                };

                // Guardar en la base de datos usando el contexto de la clase Base
                MapaRiesgoContext.Eventos.Add(evento);
                MapaRiesgoContext.SaveChanges();

                // Actualizar el ID de evidencia con el ID generado
                evidencia.IdEvidencia = evento.IdEvento;

                return new Response<EvidenciaRequest>
                {
                    Id = evento.IdEvento,
                    Status = StatusCodes.Status200OK,
                    Message = "Evidencia guardada exitosamente",
                    HasError = false,
                    Data = evidencia
                };
            }
            catch (Exception ex)
            {
                return new Response<EvidenciaRequest>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al guardar la evidencia: {ex.Message}",
                    HasError = true,
                    Data = null
                };
            }
        }

        /// <summary>
        /// Obtiene una evidencia por ID
        /// </summary>
        /// <param name="idEvento">ID del evento</param>
        /// <returns>Datos de la evidencia</returns>
        public Response<EvidenciaRequest> ObtenerEvidenciaPorId(int idEvento)
        {
            try
            {
                if (idEvento <= 0)
                {
                    return new Response<EvidenciaRequest>
                    {
                        Id = 0,
                        Status = StatusCodes.Status400BadRequest,
                        Message = "ID de evidencia inválido",
                        HasError = true,
                        Data = null
                    };
                }

                var evento = MapaRiesgoContext.Eventos
                    .Where(e => e.IdEvento == idEvento)
                    .FirstOrDefault();

                if (evento == null)
                {
                    return new Response<EvidenciaRequest>
                    {
                        Id = 0,
                        Status = StatusCodes.Status404NotFound,
                        Message = "Evidencia no encontrada",
                        HasError = true,
                        Data = null
                    };
                }

                // Mapear de Evento a EvidenciaRequest
                var evidencia = new EvidenciaRequest
                {
                    IdEvidencia = evento.IdEvento,
                    NombreFoto = evento.Evidencia ?? string.Empty,
                    Latitud = (double)evento.Latitud,
                    Longitud = (double)evento.Longitud,
                    TipoFoto = evento.IdTipoEvento.ToString(),
                    IdEmpresa = evento.IdEmpresa
                };

                return new Response<EvidenciaRequest>
                {
                    Id = evento.IdEvento,
                    Status = StatusCodes.Status200OK,
                    Message = "Evidencia obtenida exitosamente",
                    HasError = false,
                    Data = evidencia
                };
            }
            catch (Exception ex)
            {
                return new Response<EvidenciaRequest>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al obtener la evidencia: {ex.Message}",
                    HasError = true,
                    Data = null
                };
            }
        }

        /// <summary>
        /// Obtiene evidencias por ID de empresa
        /// </summary>
        /// <param name="idEmpresa">ID de la empresa/razón social</param>
        /// <returns>Lista de evidencias</returns>
        public Response<List<EvidenciaRequest>> ObtenerEvidenciasPorEmpresa(int idEmpresa)
        {
            try
            {
                if (idEmpresa <= 0)
                {
                    return new Response<List<EvidenciaRequest>>
                    {
                        Id = 0,
                        Status = StatusCodes.Status400BadRequest,
                        Message = "ID de empresa inválido",
                        HasError = true,
                        Data = null
                    };
                }

                var eventos = MapaRiesgoContext.Eventos
                    .Where(e => e.IdEmpresa == idEmpresa)
                    .OrderByDescending(e => e.Fecha)
                    .ToList();

                var evidencias = eventos.Select(evento => new EvidenciaRequest
                {
                    IdEvidencia = evento.IdEvento,
                    NombreFoto = evento.Evidencia ?? string.Empty,
                    Latitud = (double)evento.Latitud,
                    Longitud = (double)evento.Longitud,
                    TipoFoto = evento.IdTipoEvento.ToString(),
                    IdEmpresa = evento.IdEmpresa
                }).ToList();

                return new Response<List<EvidenciaRequest>>
                {
                    Id = idEmpresa,
                    Status = StatusCodes.Status200OK,
                    Message = $"Se encontraron {evidencias.Count} evidencias",
                    HasError = false,
                    Data = evidencias
                };
            }
            catch (Exception ex)
            {
                return new Response<List<EvidenciaRequest>>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al obtener evidencias: {ex.Message}",
                    HasError = true,
                    Data = null
                };
            }
        }

        /// <summary>
        /// Obtiene todas las evidencias con filtros opcionales
        /// </summary>
        /// <returns>Lista de todas las evidencias</returns>
        public Response<List<Evento>> ObtenerTodasLasEvidencias()
        {
            try
            {
                var eventos = MapaRiesgoContext.Eventos
                    .Include(e => e.IdTipoEventoNavigation)
                    .OrderByDescending(e => e.Fecha)
                    .ToList();

                return new Response<List<Evento>>
                {
                    Id = eventos.Count,
                    Status = StatusCodes.Status200OK,
                    Message = $"Se obtuvieron {eventos.Count} evidencias correctamente",
                    HasError = false,
                    Data = eventos
                };
            }
            catch (Exception ex)
            {
                return new Response<List<Evento>>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al obtener evidencias: {ex.Message}",
                    HasError = true,
                    Data = null
                };
            }
        }
    }
}
