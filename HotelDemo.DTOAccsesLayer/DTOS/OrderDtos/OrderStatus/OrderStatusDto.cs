using HotelDemo.DataAccsesLayer.Entities;

namespace HotelDemo.DTOAccsesLayer.DTOS.OrderDtos.OrderStatus;

public class OrderStatusDto : IdEntity
{
    public string Name { get; set; } = string.Empty;
}
