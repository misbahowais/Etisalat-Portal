
using CoreBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL;

public partial class PortalContext : DbContext
{
    public PortalContext(DbContextOptions<PortalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserData> UserDatas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<UserData>(entity =>
        {
            
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(250);

            entity.Property(e => e.PhoneNumber)
               .IsRequired()
               .HasMaxLength(250);

            entity.Property(e => e.CapsuleName)
               .IsRequired()
               .HasMaxLength(250);
        });

        

        OnModelCreatingPartial(modelBuilder);
    }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

   
}
