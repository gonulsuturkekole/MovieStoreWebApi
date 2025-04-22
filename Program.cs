using Microsoft.EntityFrameworkCore;
using MovieStoreWebApi.Context;

var builder = WebApplication.CreateBuilder(args);


// Add DbContext
builder.Services.AddDbContext<MovieStoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//don}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
