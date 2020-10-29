using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFramework_4Point2.Models
{
    // Inheriting from DbContext provides us most of the functionality. The rest of the file is customizing to suit our database.
    public partial class VehicleContext : DbContext
    {
        // Skeleton constructors to add to in the future.
        public VehicleContext()
        {
        }

        public VehicleContext(DbContextOptions<VehicleContext> options)
            : base(options)
        {
        }

        // Collection properties that allow you to access records from a given table through the context.
        // These should typically be plural, but some EF Core implementations (like this one) decide to make them singular.
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        // Allows configuration options to be specified. By default the connection string is here, but can be moved.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=dbfirst_4point2", x => x.ServerVersion("10.4.14-mariadb"));
            }
        }
        // Where all the options pertaining to model relationships and string collation are specified.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Specifies options for a given model (in the angle brackets).
            modelBuilder.Entity<Manufacturer>(entity =>
            {
                // Because we don't have AUTO_INCREMENT on, this was added. It typically won't be here.
                entity.Property(e => e.Id).ValueGeneratedNever();

                // Specifies collation for text types. This is ONLY necessary for strings (varchar, char, text, etc).
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                // Specifies an index (typically for FOREIGN KEYs but not always).
                entity.HasIndex(e => e.ManufacturerId)
                    .HasName("FK_Vehicle_Manufacturer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Colour)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                // Specifies the relationship between two records.
                // This entity has one Manufacturer.
                entity.HasOne(d => d.Manufacturer)
                    // That entity (manufacturer) has many of this record (vehicles).
                    .WithMany(p => p.Vehicles)
                    // This entity has a foreign key property called ManufacturerId.
                    .HasForeignKey(d => d.ManufacturerId)
                    // When the parent record is deleted, this controls behaviour.
                    // Typically this is CASCADE, but we'll discuss alternatives later.
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    // The name of the foreign key constraint.
                    .HasConstraintName("FK_Vehicle_Manufacturer");
            });

            // Call the skeleton method.
            OnModelCreatingPartial(modelBuilder);
        }

        // More skeleton methods to add to if needed.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
