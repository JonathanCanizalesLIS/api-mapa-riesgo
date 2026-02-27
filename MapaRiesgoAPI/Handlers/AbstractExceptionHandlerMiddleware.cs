
using ElectronicDataInterchange.API.Classes;
using Newtonsoft.Json;
using System.Net;
using System.Reflection;
using System.Configuration;

namespace ElectronicDataInterchange.API.Handlers
{
    /// <summary>
    /// Abstract handler for all exceptions.
    /// </summary>
    /// 
    public abstract class AbstractExceptionHandlerMiddleware
    {
        private readonly ILogger<AbstractExceptionHandlerMiddleware> Logger;
        // Enrich is a custom extension method that enriches the Serilog functionality - you may ignore it
        //private static readonly ILogger Logger = Log.ForContext(MethodBase.GetCurrentMethod()?.DeclaringType);
        private IConfiguration Configuration;


        /// <summary>   
        /// This key should be used to store the exception in the <see cref="IDictionary{TKey,TValue}"/> of the exception data,
        /// to be localized in the abstract handler.
        /// </summary>
        public static string LocalizationKey => "LocalizationKey";

        private readonly RequestDelegate _next;

        /// <summary>
        /// Gets HTTP status code response and message to be returned to the caller.
        /// Use the ".Data" property to set the key of the messages if it's localized.
        /// </summary>
        /// <param name="exception">The actual exception</param>
        /// <returns>Tuple of HTTP status code and a message</returns>
        public abstract (HttpStatusCode code, string message) GetResponse(Exception exception);

        public AbstractExceptionHandlerMiddleware(RequestDelegate next, ILogger<AbstractExceptionHandlerMiddleware> logger, IConfiguration configuration)
        {
            _next = next;
            Configuration = configuration;
            this.Logger = logger ?? throw new ArgumentNullException(nameof(logger));    
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                int errorId = (int) Math.Abs(DateTime.Now.Ticks);

                // log the error
                Logger.LogError(exception, $"{errorId}|" + "error during executing {Context}", context.Request.Path.Value);
                //Capturing the erxception to sentry
               
                var response = context.Response;
                response.ContentType = "application/json";

                // get the response code and message
                var (status, message) = GetResponse(exception);
                response.StatusCode = (int)status;

                var returnMessage = new Response
                {
                    Id = errorId,
                    Message = exception.Message.ToString(),
                    HasError = true,
                    Data = exception.InnerException?.Message?.ToString(),
                    Status = response.StatusCode
                };

                await response.WriteAsync(JsonConvert.SerializeObject(returnMessage));
            }
        }

        private void SentryCaptureError(Exception ex)
        {
            var sentryClient = new Sentry.SentryClient(new SentryOptions { Dsn = Configuration.GetSection("Sentry").GetSection("dsn").Value});

            sentryClient.CaptureEvent(new SentryEvent(ex), scope:null);

        }
    }
}
