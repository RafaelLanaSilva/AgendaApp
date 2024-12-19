using AgendaApp.API.Configurations;
using AgendaApp.Domain.Interfaces.Repositories;
using AgendaApp.Domain.Interfaces.Services;
using AgendaApp.Domain.Services;
using AgendaApp.Infra.Data.Repositories;
using AgendaApp.Infra.Messages.Consumers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(map => { map.LowercaseUrls = true; });

SwaggerConfiguration.AddSwaggerConfiguration(builder.Services);
CorsConfiguration.AddCorsConfiguration(builder.Services);
DependencyInjectionConfiguration.AddDependencyInjection(builder.Services);
MongoDBConfiguration.AddMongoDBConfiguration(builder.Services);
JwtBearerConfiguration.AddJwtSecurity(builder.Services);

builder.Services.AddHostedService<MessageConsumer>();

var app = builder.Build();

SwaggerConfiguration.UseSwaggerConfiguration(app);
CorsConfiguration.UseCorsConfiguration(app);

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();




