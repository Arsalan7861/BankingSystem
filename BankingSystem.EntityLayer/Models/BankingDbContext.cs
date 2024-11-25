using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BankingSystem.EntityLayer.Models;

public partial class BankingDbContext : DbContext
{
    public BankingDbContext()
    {
    }

    public BankingDbContext(DbContextOptions<BankingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=BankingDb;Username=postgres;Password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("Account_pkey");

            entity.ToTable("Account");

            entity.Property(e => e.AccountId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("accountId");
            entity.Property(e => e.AccountBalance).HasColumnName("accountBalance");
            entity.Property(e => e.AccountCurrency).HasColumnName("accountCurrency");
            entity.Property(e => e.AccountIban)
                .HasColumnType("char")
                .HasColumnName("accountIban");
            entity.Property(e => e.AccountType)
                .HasColumnType("char")
                .HasColumnName("accountType");
            entity.Property(e => e.CustomerId).HasColumnName("customerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("customerId");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("Branch_pkey");

            entity.ToTable("Branch");

            entity.Property(e => e.BranchId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("branchId");
            entity.Property(e => e.BranchCity)
                .HasColumnType("char")
                .HasColumnName("branchCity");
            entity.Property(e => e.BranchName)
                .HasColumnType("char")
                .HasColumnName("branchName");
            entity.Property(e => e.BranchPostCode)
                .HasColumnType("char")
                .HasColumnName("branchPostCode");
            entity.Property(e => e.BranchStreet)
                .HasColumnType("char")
                .HasColumnName("branchStreet");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerTc).HasName("Customer_pkey");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerTc)
                .ValueGeneratedNever()
                .HasColumnName("customerTc");
            entity.Property(e => e.CustomerAddress)
                .HasColumnType("char")
                .HasColumnName("customerAddress");
            entity.Property(e => e.CustomerFname)
                .HasColumnType("char")
                .HasColumnName("customerFName");
            entity.Property(e => e.CustomerLname)
                .HasColumnType("char")
                .HasColumnName("customerLName");
            entity.Property(e => e.CustomerPhonNo)
                .HasColumnType("char")
                .HasColumnName("customerPhonNo");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffTc).HasName("Staff_pkey");

            entity.Property(e => e.StaffTc)
                .ValueGeneratedNever()
                .HasColumnName("staffTc");
            entity.Property(e => e.BranchId).HasColumnName("branchId");
            entity.Property(e => e.CustomerTc).HasColumnName("customerTc");
            entity.Property(e => e.StaffAddress)
                .HasColumnType("char")
                .HasColumnName("staffAddress");
            entity.Property(e => e.StaffFname)
                .HasColumnType("char")
                .HasColumnName("staffFName");
            entity.Property(e => e.StaffLname)
                .HasColumnType("char")
                .HasColumnName("staffLName");
            entity.Property(e => e.StaffPhonNo)
                .HasColumnType("char")
                .HasColumnName("staffPhonNo");
            entity.Property(e => e.StaffPosition)
                .HasColumnType("char")
                .HasColumnName("staffPosition");

            entity.HasOne(d => d.Branch).WithMany(p => p.Staff)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("branchId");

            entity.HasOne(d => d.CustomerTcNavigation).WithMany(p => p.Staff)
                .HasForeignKey(d => d.CustomerTc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("customerId");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("Transaction_pkey");

            entity.ToTable("Transaction");

            entity.Property(e => e.TransactionId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("transactionId");
            entity.Property(e => e.TransactionAmount).HasColumnName("transactionAmount");
            entity.Property(e => e.TransactionDate).HasColumnName("transactionDate");
            entity.Property(e => e.TransactionFromId).HasColumnName("transactionFromId");
            entity.Property(e => e.TransactionToId).HasColumnName("transactionToId");

            entity.HasOne(d => d.TransactionFrom).WithMany(p => p.TransactionTransactionFroms)
                .HasForeignKey(d => d.TransactionFromId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fromId");

            entity.HasOne(d => d.TransactionTo).WithMany(p => p.TransactionTransactionTos)
                .HasForeignKey(d => d.TransactionToId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("toId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
