using aquaBack.Core.Service.IService;
using aquaBack.Data.Dto;

namespace aquaBack.Core.Service;

public class OrderService : IOrderService
{
    public async Task<bool> AddOrder(OrderDto order)
    {
        return order is null ? false : true;
    }
}