using HotelDemo.DTOAccsesLayer.DTOS.RoomTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IRoomTypeService
{
    Task<List<RoomTypeDto>> GetAll();
    Task <RoomTypeDto> GetById(int id);
    Task AddRoomType(AddRoomTypeDto addRoomTypeDto);
    Task UpdateRoomType(UpdateRoomTypeDto updateRoomTypeDto);
    Task DeleteRoomType(int id);
}