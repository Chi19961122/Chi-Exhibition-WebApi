using Chi.Exhibition.Repository.Configuration;
using Chi.Exhibition.Repository.Models;
using Chi.Exhibition.Service.Common.Jwt;
using Chi.Exhibition.Service.Common.User;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddConfiguration(); //實體化appsettings

builder.Services.AddDbContext<_ChiExhDbContext>(
        options => options.UseSqlServer(AppSettings.Connectionstrings?.ChiConn));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//依賴注入
builder.Services.AddSingleton<IJwtAuthService, JwtAuthService>();
builder.Services.AddSingleton<IUserService, UserService>();
//builder.AddAutofac();


builder.Services.AddHttpClient();

builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthorization();


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

app.Run();
