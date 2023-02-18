using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string con = "server=SKAYWINDESK; user = skay; password = Feb2023; database = Yoda; TrustServerCertificate = true";


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection") ?? con;
//builder.Services.AddSqlServer<StoreContext>(con);

builder.Services.AddDbContext<StoreContext>(opt =>
{

    opt.UseSqlServer(con);

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
