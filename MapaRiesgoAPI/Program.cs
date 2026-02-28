using MapaRiesgo.API.BusinessLogic;
using MapaRiesgo.API.Services;
using ElectronicDataInterchange.API.Classes.Autenticacion;
using ElectronicDataInterchange.API.Handlers;
using LISTMS.DL.Models;
using MapaRiesgo.DL.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using ElectronicDataInterchange.BusinessLogic;
using MapaRiesgo.API.WebSockets;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);

builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(2);
});

builder.Services.AddControllers(options => options.EnableEndpointRouting = false)
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

builder.Services.AddTransient<GenericHelper>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Mapa de Riesgo API",
        Version = "v1",
        Description = "Mapa de Riesgo API ",
    });
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Description = "JWT Authorization header using the Bearer scheme."
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[]{}
        }
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
    options.CustomSchemaIds(type => type.FullName);
});

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = false,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

builder.Services.AddMvc();

builder.Services.AddDbContext<MapaRiesgoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MapaRiesgoSQLServerDatabase"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddDbContext<ListmsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ListmsSQLServerDatabase"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<AuthenticationBusiness>();
builder.Services.AddScoped<UnidadBusiness>();

builder.Services.AddScoped<EmpresasBDConexionBusiness>();
builder.Services.AddScoped<UnidadZamBusiness>();


builder.Services.AddSingleton<WebSocketConnectionManager>();
builder.Services.AddSingleton<ChatWebSocketHandler>();


builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.SetIsOriginAllowed(_ => true)
              .AllowAnyHeader()
              .AllowAnyMethod())
);

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile($"appsettings.{app.Environment.EnvironmentName}.json")
    .Build();

if (app.Environment.IsDevelopment() || app.Environment.EnvironmentName == "Testing" || app.Environment.EnvironmentName == "Production")
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

AppContext.SetSwitch("Switch.System.Xml.AllowDefaultResolver", true);

app.UseWebSockets(new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromMinutes(2)
});

app.UseCors();

app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/ws/chat"))
    {
        if (context.WebSockets.IsWebSocketRequest)
        {
            var segments = context.Request.Path.Value.Split('/');
            if (int.TryParse(segments.Last(), out int idUsuario))
            {
                var socket = await context.WebSockets.AcceptWebSocketAsync();
                var handler = context.RequestServices.GetRequiredService<ChatWebSocketHandler>();
                await handler.Handle(idUsuario, socket);
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }
        else
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
        return;
    }

    await next();
});

app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<BackofficeExceptionHandlerMiddleware>();
app.UseMiddleware<AutenticacionMiddleware>();
app.UseMvc();
app.MapControllers();
app.Run();