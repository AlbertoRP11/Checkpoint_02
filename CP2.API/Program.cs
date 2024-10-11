using CP2.IoC; // Importa o namespace IoC

var builder = WebApplication.CreateBuilder(args);

// Adiciona os controladores
builder.Services.AddControllers();

// Configura o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Chama o m�todo para registrar os servi�os e reposit�rios
DependencyInjector.RegisterServices(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CP2 API v1");
    });
}

app.UseAuthorization();

app.MapControllers();
app.Run();
