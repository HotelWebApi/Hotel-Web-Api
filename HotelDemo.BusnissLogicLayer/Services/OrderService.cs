using AutoMapper;
using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.BusnissLogicLayer.Interfaces;
using HotelDemo.DataAccsesLayer.Entities.Orders;
using HotelDemo.DataAccsesLayer.Interfaces;
using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;

namespace HotelDemo.BusnissLogicLayer.Services;
public class OrderService(IUnitOfWork unitOfWork, IMapper mapper) : IOrderService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task AddOrder(AddOrderDto addorderDto)
    {
        if (addorderDto == null)
        {
            throw new ArgumentNullException(nameof(addorderDto));
        }
        var order = _mapper.Map<Order>(addorderDto);
        var orders = await _unitOfWork.OrderInterface.GetAllAsync();
        if (order.IsExist(orders))
        {
            throw new CustomException($"{order} - order already added");
        }
        try
        {
            var admins = await _unitOfWork.AdminInterface.GetAllAsync();
            var admin = await _unitOfWork.AdminInterface.GetByIdAsync(addorderDto.AdminId);
            if (admin.IsExist(admins))
            {
                await _unitOfWork.OrderInterface.AddAsync(order);
                await _unitOfWork.SaveAsync();
            }
            else
            {
                throw new CustomException("Admin is not");
            }
        }
        catch (CustomException ex)
        {
            throw new CustomException(ex.Message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task DeleteOrder(int id)
    {
        var order = await _unitOfWork.OrderInterface.GetByIdAsync(id);
        if (order == null)
        {
            throw new ArgumentNullException();
        }
        await _unitOfWork.OrderInterface.DeleteAsync(order);
        await _unitOfWork.SaveAsync();
    }

    public async Task<List<OrderDto>> GetAll()
    {
        var orders = await _unitOfWork.OrderInterface.GetAllAsync();
        return orders.Select(o => _mapper.Map<OrderDto>(o)).ToList();
    }

    public async Task<OrderDto> GetById(int id)
    {
        var order = await _unitOfWork.OrderInterface.GetByIdAsync(id);
        if (order == null)
        {
            throw new ArgumentNullException();
        }
        return _mapper.Map<OrderDto>(order);
    }

    public async Task UpdateOrder(UpdateOrderDto updateorderDto)
    {
        if (updateorderDto == null)
        {
            throw new ArgumentNullException(nameof(updateorderDto));
        }
        var order = _mapper.Map<Order>(updateorderDto);
        var orders = await _unitOfWork.OrderInterface.GetAllAsync();
        if (order.IsExist(orders))
        {
            throw new CustomException($"{order} - order already added");
        }
        try
        {
            await _unitOfWork.OrderInterface.UpdateAsync(order);
            await _unitOfWork.SaveAsync();
        }
        catch (CustomException ex)
        {
            throw new CustomException(ex.Message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
