
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelDemo.DataAccsesLayer.Entities;

public class Admin : BaseEntitiy
{
    public string Address { get; set; } = string.Empty!;
}
