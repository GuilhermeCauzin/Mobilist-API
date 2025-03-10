using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MobilistAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

builder.Services.AddIdentityApiEndpoints<Usuario>()
    .AddEntityFrameworkStores<ProjetoMobilistContext>();

builder.Services.AddDbContext<ProjetoMobilistContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("Development")
    )
);

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapIdentityApi<Usuario>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options=>options.SwaggerEndpoint("/openapi/v1.json","Controladores"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
