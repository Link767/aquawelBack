using aquaBack.Data.Dto;

namespace aquaBack.Core.Service.IService;

public interface IOrderService
{
    Task<bool> AddOrder(OrderDto order);
}