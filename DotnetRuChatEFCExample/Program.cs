using DotnetRuChatEFCExample.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<ExampleDbContext>(optionsBuilder =>
{
    optionsBuilder.UseNpgsql("User ID=postgres;Password=12345;Host=localhost;Port=5432;Database=dotnetru_efcore_example;");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var contextFactory = app.Services.GetRequiredService<IDbContextFactory<ExampleDbContext>>();
await using var context = await contextFactory.CreateDbContextAsync();
await context.Database.MigrateAsync();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
