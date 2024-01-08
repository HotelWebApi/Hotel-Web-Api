using AutoMapper;
using HotelDemo.BusnissLogicLayer.Interfaces;
using HotelDemo.DataAccsesLayer.Interfaces;
using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;


namespace HotelDemo.BusnissLogicLayer.Services;

public class OrderService(IUnitOfWork unitOfWork, IMapper mapper) : IOrderService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task AddOrder(OrderStatusDto orderStatusDto)
    {

        throw new NotImplementedException();
    }

    public async Task DeleteOrder(int id)
    {

        throw new NotImplementedException();
    }

    public Task<List<OrderDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOrder(UpdateStatusDto updateStatusDto)
    {
        throw new NotImplementedException();
    }
}
