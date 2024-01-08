using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos.OrderStatus;
using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos.OrderStatusDtos;


namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IOrderStatusService
{
    Task<List<OrderStatusDto>> GetAllAsync();
    Task<OrderStatusDto> GetByIdAsync(int id);
    Task Add(AddOrderStatusDto orderStatus);
    Task Update(UpdateOrderStatusDto orderStatus);
    Task Delete(int id);
}
