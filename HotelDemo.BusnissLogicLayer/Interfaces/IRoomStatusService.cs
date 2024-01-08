using HotelDemo.DTOAccsesLayer.DTOS.RoomDtos.RoomStatusDtos;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IRoomStatusService
{
    Task<List<RoomStatusDto>> GetAllRoomStatus();
    Task <RoomStatusDto> GetRoomStatusById(int Id);
    Task AddRoomStatus(AddRoomStatusDto roomStatusDto);
    Task UpdateRoomStatus(UpdateRoomStatusDto roomStatusDto);
    Task DeleteRoomStatus(int Id);
}
