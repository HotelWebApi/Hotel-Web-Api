﻿using System.ComponentModel.DataAnnotations;

namespace HotelDemo.DTOAccsesLayer.DTOS.GuestDtos;

public class AddGuestDto
{
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "FirstName length must be between 3 and 50")]
    public string FirstName { get; set; } = string.Empty!;

    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "LastName length must be between 3 and 50")]
    public string LastName { get; set; } = string.Empty!;

    [StringLength(50, MinimumLength = 3, ErrorMessage = "FatherName length must be between 3 and 50")]
    public string FatherName { get; set; } = string.Empty!;

    [Required(ErrorMessage = "This Required Example 2020-01-05 Realy easy"), StringLength(16)]
    public string AddedTime { get; set; } = string.Empty!;

    [Required(ErrorMessage = "This Required Example 2020-01-05 Realy easy"), StringLength(16)]
    public string EditedTime { get; set; } = string.Empty!;

    [StringLength(15)]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(60, ErrorMessage = "Passport length must be less than 60")]
    public string Passport { get; set; } = string.Empty;

    [Required(ErrorMessage = "This Required Example 2020-01-05 Realy easy"), StringLength(16)]
    public string BirthDate { get; set; } = string.Empty!;
    [Required(ErrorMessage = "This Required Example 2020-01-05 Realy easy"), StringLength(16)]
    public string DateOfIssue { get; set; } = string.Empty!; 

    [StringLength(100)]
    public string Address { get; set; } = string.Empty;

    [StringLength(50)]
    public string OrganizationName { get; set; } = string.Empty;

    [StringLength(50)]
    public string Givenbywhom { get; set; } = string.Empty;

    [StringLength(50)]
    public string Citizenship { get; set; } = string.Empty;

    [StringLength(50)]
    public string Description { get; set; } = string.Empty;

    [StringLength(50)]
    public string Organization { get; set; } = string.Empty;

    [StringLength(5)]
    public string Gender { get; set; } = string.Empty;

    [Required]
    public int AdminId { get; set; }
}
