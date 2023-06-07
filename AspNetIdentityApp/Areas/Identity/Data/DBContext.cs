using AspNetIdentityApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetIdentityApp.Areas.Identity.Data;

public class DBContext : IdentityDbContext<AspNetIdentityAppUser>
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AspNetIdentityAppUser>
{
    public void Configure(EntityTypeBuilder<AspNetIdentityAppUser> builder)
    {
        builder.Property(x=> x.FirstName).HasMaxLength(100);
        builder.Property(x => x.LastName).HasMaxLength(100);
        builder.Property(x => x.PhoneNumber).HasMaxLength(12);

    }
}