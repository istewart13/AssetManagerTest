using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AssetManagerTest.Models
{
    public partial class AssetManagerContext : DbContext
    {
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }

        public AssetManagerContext(DbContextOptions<AssetManagerContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.AddressLine2).HasMaxLength(40);

                entity.Property(e => e.AddressLine3).HasMaxLength(40);

                entity.Property(e => e.PostCode).HasMaxLength(8);

                entity.Property(e => e.Town).HasMaxLength(40);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(12);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Customer__AssetI__398D8EEE");
            });
        }
    }
}
