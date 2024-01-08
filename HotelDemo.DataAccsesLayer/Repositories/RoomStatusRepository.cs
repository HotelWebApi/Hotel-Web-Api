using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DataAccsesLayer.Entities.Rooms;
using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class RoomStatusRepository : Repository<RoomStatus>, IRoomStatusInterface
{
    public RoomStatusRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

}