using aquaBack.Core.Service.IService;
using aquaBack.Data.Dto;

namespace aquaBack.Core.Endpoints;

public static class OrderEndpoints
{
    public static void MapOrder(this IEndpointRouteBuilder app)
    {
        app.MapPost("aqua/addOrder", async (OrderDto order, IOrderService service) =>
        {
            return await service.AddOrder(order) ? Results.Ok(200) : Results.BadRequest();
        });
    }
}