using GymPro.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var cadenaConexion = builder.Configuration.GetConnectionString("GymPro")
    ?? throw new InvalidOperationException("Falta la cadena de conexión 'GymPro'.");

builder.Services.AgregarInfraestructura(cadenaConexion);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
