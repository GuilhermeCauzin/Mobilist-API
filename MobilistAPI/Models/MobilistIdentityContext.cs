using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MobilistAPI.Models
{
    public class MobilistIdentityContext : IdentityDbContext<Usuario>
    {
        public MobilistIdentityContext(DbContextOptions<MobilistIdentityContext> options)
        : base(options)
        {
        }
        protected MobilistIdentityContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }



    }
}
