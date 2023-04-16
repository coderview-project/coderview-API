using coderview_API.IService;
using coderview_API.Service;
using Data;
using Logic.ILogic;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IEvaluationService, EvaluationService>();
builder.Services.AddScoped<IEvaluationTypeService, EvaluationTypeService>();
builder.Services.AddScoped<IEvaluationStateService, EvaluationStateService>();
builder.Services.AddScoped<IUserRolService, UserRolService>();

//Logic
builder.Services.AddScoped<IUserLogic, UserLogic>();
builder.Services.AddScoped<IEvaluationLogic, EvaluationLogic>();
builder.Services.AddScoped<IEvaluationTypeLogic, EvaluationTypeLogic>();
builder.Services.AddScoped<IEvaluationStateLogic, EvaluationStateLogic>();
builder.Services.AddScoped<IUserRolLogic, UserRolLogic>();

builder.Services.AddDbContext<ServiceContext>(
        options => options.UseSqlServer("name=ConnectionStrings:ServiceContext"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
    builder =>
    {
        builder.AllowAnyOrigin()
     .AllowAnyMethod()
    .AllowAnyHeader();
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

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
