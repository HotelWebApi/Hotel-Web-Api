using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IOrderService
{
    Task<List<OrderDto>> GetAll();
    Task <OrderDto> GetById(int id);
    Task AddOrder(OrderStatusDto orderStatusDto);
    Task UpdateOrder(UpdateStatusDto updateStatusDto);
    Task DeleteOrder(int id);
}