using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Entities.Orders;
using HotelDemo.DataAccsesLayer.Entities.Rooms;
using HotelDemo.DataAccsesLayer.Entities.Staffs;
using Microsoft.EntityFrameworkCore;

namespace HotelDemo.DataAccsesLayer;

public class AppDbContext(DbContextOptions<AppDbContext> options)
        : DbContext(options)
{
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<RoomStatus> RoomStatuses { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderStatus> OrderStatuses { get; set; }
    public DbSet<Admin> Admins { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Room>()
            .HasOne(e => e.RoomType)
            .WithMany(rt => rt.Rooms)
            .HasForeignKey(e => e.RoomTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Room>()
            .HasOne(e => e.RoomStatus)
            .WithMany(rs => rs.Rooms)
            .HasForeignKey(e => e.RoomStatusId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
           .HasKey(o => o.Id);

        modelBuilder.Entity<OrderStatus>()
            .HasKey(os => os.Id);

        base.OnModelCreating(modelBuilder);
    }
}
