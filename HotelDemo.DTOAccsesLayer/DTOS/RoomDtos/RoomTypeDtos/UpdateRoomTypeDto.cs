using HotelDemo.DataAccsesLayer.Entities;

namespace HotelDemo.DTOAccsesLayer.DTOS.RoomTypeDtos;

public class UpdateRoomTypeDto : IdEntity
{
    public string Name { get; set; } = string.Empty;
    public int PersonCount { get; set; }
}
