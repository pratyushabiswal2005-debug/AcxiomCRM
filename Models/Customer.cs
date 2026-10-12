
using System.ComponentModel.DataAnnotations;

namespace AcxiomCRM.Models;

public class Customer
{
    public int CustomerId { get; set; }

    [Required, StringLength(100)]
    public string CustomerName { get; set; } = "";

    [Required, EmailAddress, StringLength(150)]
    public string Email { get; set; } = "";

    [Required, RegularExpression(@"^[0-9]{10}$",
        ErrorMessage = "Enter a valid 10-digit phone number.")]
    public string Phone { get; set; } = "";

    [StringLength(150)]
    public string? CompanyName { get; set; }

    [StringLength(250)]
    public string? Address { get; set; }

    [StringLength(80)]
    public string? City { get; set; }

    [StringLength(80)]
    public string? State { get; set; }

    public string Status { get; set; } = "Active";

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}
