using DATA;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DeviceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DeviceConnection"))
);

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var datacontext = scope.ServiceProvider.GetRequiredService<DeviceContext>();
    datacontext.Database.Migrate();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
