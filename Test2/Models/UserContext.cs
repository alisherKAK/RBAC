using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Test2.Models.Identity;

namespace Test2.Models
{
    public class UserContext : IdentityDbContext<User, Role, int, UserLogin, UserRole, UserClaim>
    {
        public UserContext() : base("DefaultConnection")
        {}

        public override IDbSet<User> Users { get; set; }
        public override IDbSet<Role> Roles { get; set; }
        public IDbSet<UserLogin> UserLogins { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }
        public IDbSet<UserClaim> UserClaims { get; set; }

        public static UserContext Create()
        {
            return new UserContext();
        }
    }
}