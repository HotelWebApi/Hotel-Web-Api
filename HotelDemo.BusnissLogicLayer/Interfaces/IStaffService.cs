using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.DTOAccsesLayer.DTOS.StaffDtos;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IStaffService
{
    Task<List<StaffDto>> GetAllAsync();
    Task<PagedList<StaffDto>> GetAllPagedAsync(int pageSize, int pageNumber);
    Task<StaffDto> GetByIdAsync(int id);
    Task AddAsync(AddStaffDto staffDtoDto);
    Task UpdateAsync(UpdateStaffDto updatedStaffDtoDto);
    Task DeleteAsync(int id);
}
