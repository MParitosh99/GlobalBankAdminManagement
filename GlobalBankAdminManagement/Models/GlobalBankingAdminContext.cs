using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GlobalBankAdminManagement.Models
{
    public partial class GlobalBankingAdminContext : DbContext
    {
        public GlobalBankingAdminContext()
        {
        }

        public GlobalBankingAdminContext(DbContextOptions<GlobalBankingAdminContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<GlobalBankBranch> GlobalBankBranches { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=WINDOWS-UNR7VLH\\SQLEXPRESS; Database=GlobalBankingAdmin; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Admin");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("accountNo");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("branchId");

                entity.Property(e => e.CustomerNo).HasColumnName("customerNo");

                entity.Property(e => e.OpeningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("openingDate");
            });

            modelBuilder.Entity<GlobalBankBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GlobalBankBranch");

                entity.Property(e => e.BranchAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branchAddress");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("branchId");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branchName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
