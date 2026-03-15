using aquaBack.Core.Endpoints;
using aquaBack.Core.Service;
using aquaBack.Core.Service.IService;
using aquaBack.Data;
using aquaBack.Data.Repository;
using aquaBack.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace aquaBack.Core;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddOpenApi();
        /*====BD====*/
        builder.Services.AddDbContext<DataBaseContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
        /*====DI====*/
        builder.Services.AddScoped<IOrderService, OrderService>();
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        
        var app = builder.Build();
        /*====Endpoints====*/
        app.MapOrder();
        
        app.Run();
    }
}