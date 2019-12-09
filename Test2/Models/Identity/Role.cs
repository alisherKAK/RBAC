using Microsoft.AspNet.Identity.EntityFramework;

namespace Test2.Models.Identity
{
    public class Role : IdentityRole<int, UserRole>
    {
        public string Length { get; set; }
    }
}