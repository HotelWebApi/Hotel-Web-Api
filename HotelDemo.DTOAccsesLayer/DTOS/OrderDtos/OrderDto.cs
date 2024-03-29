﻿using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Entities.Orders;
using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos.OrderStatus;
using System.ComponentModel.DataAnnotations;

public class OrderDto : IdEntity
{
    public int GuestId { get; set; }
    public int AdminId { get; set; }
    public int StatusId { get; set; }
    [Required(ErrorMessage = "This Required Example 2020-01-05 Realy easy"), StringLength(16)]
    public string StartDate { get; set; } = string.Empty!;
    [Required(ErrorMessage = "This Required Example 2020-01-05 Realy easy"), StringLength(16)]
    public string EndDate { get; set; } = null!;
}
