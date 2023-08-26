using GiftQRDataAccess.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GiftQRDataAccess.DAL.Contexts
{
    public class GQRContext : IdentityDbContext<User,Role,int>
    {
        private string _connectionString;

        public GQRContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public GQRContext(DbContextOptions<GQRContext> options)
            : base(options)
        {
        }

        #region DBSets
        //public virtual DbSet<>  { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UsersTokens");
        }
    }
}
