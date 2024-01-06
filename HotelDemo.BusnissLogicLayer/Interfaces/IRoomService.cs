using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.DTOAccsesLayer.DTOS.RoomDtos;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IRoomService
{
    Task<List<RoomDto>> GetAllAsync();
    Task<RoomDto> GetByIdAsync(int id);
    Task<PagedList<RoomDto>> GetAllPagedAsync(int pageSize, int pageNumber);
    Task AddAsync(AddRoomDto roomDto);
    Task UpdateAsync(UpdateRoomDto updateRoomDto);
    Task DeleteAsync(int id);
}
