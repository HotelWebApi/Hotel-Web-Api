using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.DTOAccsesLayer.DTOS.AdminDtos;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IAdminService
{
    Task<List<AdminDto>> GetAllAsync();
    Task<AdminDto> GetByIdAsync(int id);
    Task AddAsync(AddAdminDto adminDto);
    Task<PagedList<AdminDto>> GetAllPagedAsync(int pageSize, int pageNumber);
    Task DeleteAsync(int id);
    Task UpdateAsync(UpdateAdminDto adminDto);
}
