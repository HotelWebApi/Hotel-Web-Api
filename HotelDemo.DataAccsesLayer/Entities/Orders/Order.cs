using HotelDemo.DataAccsesLayer.Entities.Guests;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelDemo.DataAccsesLayer.Entities.Orders;

public class Order : IdEntity
{
    public int AdminId { get; set; }
    public int GuestId { get; set; }
    public int StatusId { get; set; }
    [Required(ErrorMessage = "This Required Example 2020-01-05 Realy easy"), StringLength(16)]
    public string StartDate { get; set; } = string.Empty!;
    [Required(ErrorMessage = "This Required Example 2020-01-05 Realy easy"), StringLength(16)]
    public string EndDate { get; set; } = null!;
}