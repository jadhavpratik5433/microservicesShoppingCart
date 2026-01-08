using Microsoft.AspNetCore.Identity;

namespace ProjectMMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual StudentsClass Student { get; set; }
    }
}
