using RevolverBackend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();   // Required for Swagger
builder.Services.AddSwaggerGen();            // Registers Swagger services
builder.Services.AddSingleton<IPlayerService, PlayerService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();                        // Generates Swagger JSON
    app.UseSwaggerUI();                      // Enables Swagger UI at /swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
