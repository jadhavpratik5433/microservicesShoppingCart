using System.ComponentModel.DataAnnotations;

public class StudentRegisterViewModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(18, 150)]
    public int Age { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Class { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [Phone]
    public string Phone { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}
