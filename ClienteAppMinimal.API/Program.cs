using ClienteAppMinimal.Data.Contexts;
using ClienteAppMinimal.Domain.Entities;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseSwagger();
app.UseSwaggerUI();

app.MapScalarApiReference(options => { options.WithTheme(ScalarTheme.Mars); });

app.UseCors("AllowAll");

app.MapPost("/api/v1/clientes", (ClienteRequest request) =>
{
    var cliente = new Cliente { Nome = request.Nome, Email = request.Email };

    using var dataContext = new DataContext();
    dataContext.Clientes.Add(cliente);
    dataContext.SaveChanges();

    var response = new ClienteResponse(cliente.Id, cliente.Nome, cliente.Email, cliente.DataHoraCadastro);
    return Results.Ok(response);
});

app.MapGet("/api/v1/clientes", () =>
{
    using var dataContext = new DataContext();

    var response = dataContext.Clientes
        .OrderBy(c => c.Nome)
        .Select(c => new ClienteResponse(c.Id, c.Nome, c.Email, c.DataHoraCadastro))
        .ToList();

    return Results.Ok(response);
});

app.Run();

#region Records

public record ClienteRequest(string Nome, string Email);
public record ClienteResponse(Guid id, string Nome, string Email, DateTime dataHoraCriacao);

#endregion