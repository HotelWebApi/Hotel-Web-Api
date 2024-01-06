using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Entities.Staffs;
using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DataAccsesLayer;
using Microsoft.EntityFrameworkCore;
using HotelDemo.DataAccsesLayer.Entities.Rooms;

namespace HotelDemo.BusnissLogicLayer.Extended
{
    public static class Validator
    {
        public static bool IsValid(this Staff staff)
            => !string.IsNullOrEmpty(staff.FirstName)
               && !string.IsNullOrEmpty(staff.LastName)
               && !string.IsNullOrEmpty(staff.FatherName)
               && !string.IsNullOrEmpty(staff.Gender)
               && staff.FirstName.Length >= 2
               && staff.FirstName.Length <= 50
               && staff.LastName.Length >= 2
               && staff.FirstName.Length <= 50;

        public static bool IsValid(this Guest guest)
            => !string.IsNullOrEmpty(guest.FirstName)
               && !string.IsNullOrEmpty(guest.LastName)
               && !string.IsNullOrEmpty(guest.FatherName)
               && !string.IsNullOrEmpty(guest.Gender)
               && guest.FirstName.Length >= 2
               && guest.FirstName.Length <= 50
               && guest.LastName.Length >= 2
               && guest.FirstName.Length <= 50;

        public static bool IsValid(this Admin admin)
            => admin != null
               &&!string.IsNullOrEmpty(admin.FirstName)
               && !string.IsNullOrEmpty(admin.LastName)
               && !string.IsNullOrEmpty(admin.FatherName)
               && admin.FirstName.Length >= 2
               && admin.FirstName.Length <= 50
               && admin.LastName.Length >= 2
               && admin.FirstName.Length <= 50;

        public static bool IsValid(this Room room)
            => room != null;
               
        public static bool IsValid (this RoomStatus roomStatus)
            => roomStatus != null
            && !string.IsNullOrEmpty(roomStatus.Name);

        public static bool IsExist(this Admin admin, IEnumerable<Admin> admins)
            => admins.Any(a => a.FirstName == admin.FirstName
            && a.LastName == admin.LastName
            && a.FatherName == admin.FatherName);

        public static bool IsExist(this Room room, IEnumerable<Room> rooms)
            => room != null
            && rooms.Any(r => r.RoomType == room.RoomType 
            && r.RoomStatus == room.RoomStatus
            && r.Number == room.Number);
    }
}
