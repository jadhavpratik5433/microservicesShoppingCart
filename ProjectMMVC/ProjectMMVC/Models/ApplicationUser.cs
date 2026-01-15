using Microsoft.AspNetCore.Identity;

namespace ProjectMMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public StudentsClass Student { get; set; }
    }
}
