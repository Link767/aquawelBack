using aquaBack.Core.Endpoints;
using aquaBack.Core.Service;
using aquaBack.Core.Service.IService;

namespace aquaBack.Core;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddOpenApi();

        builder.Services.AddScoped<IOrderService, OrderService>();
        
        var app = builder.Build();
        /*====Endpoints====*/
        app.MapOrder();
        app.Run();
    }
}