using Newtonsoft.Json;
using System.Net;

namespace ElectronicDataInterchange.API.Handlers
{
    public class BackofficeExceptionHandlerMiddleware : AbstractExceptionHandlerMiddleware
    {
        public BackofficeExceptionHandlerMiddleware(RequestDelegate next, ILogger<AbstractExceptionHandlerMiddleware> logger, IConfiguration configuration) : base(next, logger, configuration)
        {
        }

        public override (HttpStatusCode code, string message) GetResponse(Exception exception)
        {
            HttpStatusCode code;
            switch (exception)
            {
                /*
                case KeyNotFoundException
                    or NoSuchUserException
                    or FileNotFoundException:
                    code = HttpStatusCode.NotFound;
                    break;
                case EntityAlreadyExists:
                    code = HttpStatusCode.Conflict;
                    break;
                case UnauthorizedAccessException
                    or ExpiredPasswordException
                    or UserBlockedException:
                    code = HttpStatusCode.Unauthorized;
                    break;
                case CreateUserException
                    or ResetPasswordException
                    or ArgumentException
                    or InvalidOperationException:
                    code = HttpStatusCode.BadRequest;
                    break;
                */
                default:
                    code = HttpStatusCode.InternalServerError;
                    break;
            }
            return (code, JsonConvert.SerializeObject(exception.Message));
        }
    }
}
