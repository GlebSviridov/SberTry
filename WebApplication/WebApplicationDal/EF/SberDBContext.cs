using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplicationDal.Entities;

namespace WebApplicationDal
{
    public partial class SberDBContext : DbContext
    {
        private string connection;

        public SberDBContext(string connectionString)
        {
            connection = connectionString;
        }

        

        public virtual DbSet<FirstTable> FirstTable { get; set; }
        public virtual DbSet<LogTable> LogTable { get; set; }
        public virtual DbSet<SecondTable> SecondTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FirstTable>(entity =>
            {
                entity.ToTable("First_Table");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TableDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<LogTable>(entity =>
            {
                entity.Property(e => e.FilterName).HasMaxLength(255);

                entity.Property(e => e.WhenItUse).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SecondTable>(entity =>
            {
                entity.ToTable("Second_Table");

                entity.Property(e => e.FtableId).HasColumnName("FTableId");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.SomeDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Ftable)
                    .WithMany(p => p.SecondTable)
                    .HasForeignKey(d => d.FtableId)
                    .HasConstraintName("FK__Second_Ta__FTabl__25869641");
            });
        }
    }
}
