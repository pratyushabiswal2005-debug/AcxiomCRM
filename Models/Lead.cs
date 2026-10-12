
using System.ComponentModel.DataAnnotations;

namespace AcxiomCRM.Models;

public class Lead
{
    public int LeadId { get; set; }

    [Required, StringLength(100)]
    public string LeadName { get; set; } = "";

    [EmailAddress]
    public string? Email { get; set; }

    [RegularExpression(@"^[0-9]{10}$")]
    public string? Phone { get; set; }

    public string? CompanyName { get; set; }

    [Required]
    public string Source { get; set; } = "Website";

    [Required]
    public string Status { get; set; } = "New";

    [Range(0, 1000000000)]
    public decimal ExpectedValue { get; set; }

    public string? AssignedTo { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}
