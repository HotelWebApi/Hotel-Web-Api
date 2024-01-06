using AutoMapper;
using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.BusnissLogicLayer.Interfaces;
using HotelDemo.DataAccsesLayer;
using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Interfaces;
using HotelDemo.DTOAccsesLayer.DTOS.AdminDtos;
using HotelDemo.DTOAccsesLayer.DTOS.GuestDtos;

namespace HotelDemo.BusnissLogicLayer.Services;

public class AdminService(IUnitOfWork unitOfWork, IMapper mapper) : IAdminService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task AddAsync(AddAdminDto adminDto)
    {
        if (adminDto == null)
        {
            throw new ArgumentNullException(nameof(adminDto));
        }

        var admin = _mapper.Map<Admin>(adminDto);

        try
        {
            var admins = await _unitOfWork.AdminInterface.GetAllAsync();
            if (admin.IsExist(admins))
            {
                throw new CustomException($"{admin.FirstName} {admin.LastName} {admin.FatherName} already Exist!");
            }

            await _unitOfWork.AdminInterface.AddAsync(admin);
            await _unitOfWork.SaveAsync();
        }
        catch (CustomException ex)
        {
            throw new Exception(ex.Message);
        }

        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task DeleteAsync(int id)
    {
        var adminTask = _unitOfWork.AdminInterface.GetByIdAsync(id);
        var admin = await adminTask;
        if (!admin.IsValid())
        {
            throw new CustomException($"{nameof(admin)} cannot be deleted");
        }
        await _unitOfWork.AdminInterface.DeleteAsync(admin);
        await _unitOfWork.SaveAsync();
    }

    public async Task<List<AdminDto>> GetAllAsync()
    {
        var admins = await _unitOfWork.AdminInterface.GetAllAsync();
        return admins.Select(g => _mapper.Map<AdminDto>(g))
                         .ToList();
    }

    public async Task<PagedList<AdminDto>> GetAllPagedAsync(int pageSize, int pageNumber)
    {
        var admins = await GetAllAsync();
        PagedList<AdminDto> pagedList = new(admins, admins.Count, pageNumber, pageSize);
        return pagedList.ToPagedList(admins,
                                      pageSize,
                                      pageNumber);
    }

    public async Task<AdminDto> GetByIdAsync(int id)
    {
        var admin = await _unitOfWork.AdminInterface.GetByIdAsync(id);
        if (admin is null)
        {
            throw new ArgumentException("Education is not");
        }
        return _mapper.Map<AdminDto>(admin);
    }

    public async Task UpdateAsync(UpdateAdminDto adminDto)
    {
        try
        {
            var admin1 = _mapper.Map<Admin>(adminDto);
            var admins = await _unitOfWork.AdminInterface.GetAllAsync();
            if (admin1.IsExist(admins))
            {
                throw new CustomException($"{admin1.FirstName} {admin1.LastName} {admin1.FatherName} already Exist!");
            }
            if (adminDto is null)
            {
                throw new ArgumentNullException(nameof(adminDto), "Updated admin information is null");
            }

            var admin = await _unitOfWork.AdminInterface.GetByIdAsync(adminDto.Id);
            if (admin is null)
            {
                throw new ArgumentException($"No admin found with Id {adminDto.Id}", nameof(adminDto.Id));
            }
            _mapper.Map(adminDto, admin);

            if (!admin.IsValid())
            {
                throw new CustomException("admin information is invalid!");
            }

            await _unitOfWork.AdminInterface.UpdateAsync(admin);
            await _unitOfWork.SaveAsync();
        }
        catch (Exception ex)
        {
            throw new CustomException(ex.Message);
        }
    }
}
