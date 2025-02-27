namespace JokesApp.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Employee
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(100)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    [Required]
    [StringLength(100)]
    public string Position { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Salary { get; set; }


    [Required]
    public DateTime DateOfHire { get; set; }

    public DateTime? DateOfTermination { get; set; }

    [Required]
    public bool IsActive { get; set; } = true;
}

