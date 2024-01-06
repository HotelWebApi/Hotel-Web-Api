using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.BusnissLogicLayer.Interfaces;
using HotelDemo.DTOAccsesLayer.DTOS.AdminDtos;
using HotelDemo.DTOAccsesLayer.DTOS.GuestDtos;
using Microsoft.AspNetCore.Mvc;

namespace HotelDemo.BusnissLogicLayer.Services;

[ApiController]
[Route("[controller]")]
public class AdminController(IAdminService adminService) : ControllerBase
{
    private readonly IAdminService _adminService = adminService;
    [HttpGet("Get-all")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var admins = await _adminService.GetAllAsync();
            return Ok(admins);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            var admin = await _adminService.GetByIdAsync(id);
            return Ok(admin);
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost("add-admin")]
    public async Task<IActionResult> AddStaff(AddAdminDto addAdminDto)
    {
        try
        {
            await _adminService.AddAsync(addAdminDto);
            return Ok("added");
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }

        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }

        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("paged")]
    public async Task<IActionResult> Get(int pageSize = 10, int pageNumber = 1)
    {
        try
        {
            var staffs = await _adminService.GetAllPagedAsync(pageSize, pageNumber);
            return Ok(staffs);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut]
    public async Task<IActionResult> Put(UpdateAdminDto dto)
    {
        try
        {
            await _adminService.UpdateAsync(dto);
            return Ok("updated");
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _adminService.DeleteAsync(id);
            return Ok("deleted");
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
