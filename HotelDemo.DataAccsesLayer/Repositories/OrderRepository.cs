using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Entities.Orders;
using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class OrderRepository(AppDbContext dbContext)
    : Repository<Order>(dbContext), IOrderInterface
{

    //public int Id { get; set; }
    //public int AdminId { get; set; }
    //public Admin Admin { get; set; }
    //public DateTime StartDate { get; set; }
    //public DateTime EndDate { get; set; }
}
