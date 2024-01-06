using HotelDemo.DTOAccsesLayer.DTOS.AdminDtos;
using HotelDemo.DTOAccsesLayer.DTOS.GuestDtos;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;

public class OrderDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int GuestId { get; set; } 
    [ForeignKey("GuestId")]
    public GuestDto Guest { get; set; } = new();
    public int AdminId { get; set; } 
    [ForeignKey("AdminId")]
    public AdminDto Admin { get; set; } = new();
    public int StatusId { get; set; }
    [ForeignKey("StatusId")]
    public OrderStatusDto Status { get; set; } = new();
}
