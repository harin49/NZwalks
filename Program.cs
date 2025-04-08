using Microsoft.EntityFrameworkCore;
using NZwalks.Data;
using NZwalks.Mappers;
using NZwalks.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NZwalksDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("NZwalksConnectionString")));


builder.Services.AddScoped<IRegionRepository, RegionRepository>();
builder.Services.AddScoped<IWalksRepository, WalksRepository>();
builder.Services.AddScoped<DBInitialiser>();
builder.Services.AddAutoMapper(typeof(RegionsMapper), typeof(WalksMapper));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var initaliser = scope.ServiceProvider.GetRequiredService<DBInitialiser>();
        initaliser.Run();
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
