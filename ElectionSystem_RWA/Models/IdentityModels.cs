using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ElectionSystem_RWA.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
        public DbSet<Qualification> qualifications { get; set; }
        public DbSet<Posting> postings { get; set; }
       // public DbSet<CandidateRegistration> CandidateRegistrations { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Voter> Voters { get; set; }
        public DbSet<President> Presidents { get; set; }
        public DbSet<VicePresident> VicePresident { get; set; }
        public DbSet<Secretary> Secretary { get; set; }
        public DbSet<Treasurer> Treasurer { get; set; }
        public DbSet<Members> Members { get; set; }

    }


}