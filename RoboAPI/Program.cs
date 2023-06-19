using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RoboAPI.CrossCutting.DependencyInjection;
using RoboAPI.CrossCutting.Mappings;
using RoboAPI.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
ConfigureServices.ConfigureDependenciesService(builder.Services);
ConfigureRepository.ConfigureDependenciesRepository(builder.Services);
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new DtoToModelProfile());
    cfg.AddProfile(new ModelToEntityProfile());
    cfg.AddProfile(new EntityToDtoProfile());
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();


builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API Robo .NET6.0",
        Description = "API Robo - Desenvolvido por Henrique Marques \U0001f91f",
        TermsOfService = new Uri("https://github.com/MarquesRick"),
        Contact = new OpenApiContact
        {
            Name = "Henrique Marques",
            Email = "henmarques2009@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/henri-marques/")
        },
        License = new OpenApiLicense
        {
            Name = "Termo de Licença de Uso",
            Url = new Uri("https://github.com/MarquesRick")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));

app.Run();
