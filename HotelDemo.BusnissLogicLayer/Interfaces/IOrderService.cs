using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IOrderService
{
    Task<List<OrderDto>> GetAll();
    Task<OrderDto> GetById(int id);
    Task AddOrder(AddOrderDto addorderDto);
    Task UpdateOrder(UpdateOrderDto updateorderDto);
    Task DeleteOrder(int id);
}