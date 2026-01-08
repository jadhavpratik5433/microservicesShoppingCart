using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ProjectMMVC.Models
{
    public class StudentsClass
    {
        [Required]
        [Key]
        public int Id { get; set; }
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
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
