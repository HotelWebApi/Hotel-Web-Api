﻿using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.DTOAccsesLayer.DTOS.GuestDtos;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IGuestService
{
    Task<List<GuestDto>> GetAllAsync();
    Task<GuestDto> GetByIdAsync(int id);
    Task<PagedList<GuestDto>> GetAllPagedAsync(int pageSize, int pageNumber);
    Task AddAsync(AddGuestDto GuestDto);
    Task UpdateAsync(UpdateGuestDto updatedGuestDto);
    Task DeleteAsync(int id);
    //kebf4vyub4iugvfuoifh
    //4fr09ewhtiuge54we9rg8iunjerkewg
}
