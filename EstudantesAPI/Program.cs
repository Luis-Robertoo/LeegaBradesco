using EstudantesAPI.Interfaces;
using EstudantesAPI.Repositories;
using EstudantesAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseContext>();
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IAlunoRepositorie, AlunoRepositorie>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
