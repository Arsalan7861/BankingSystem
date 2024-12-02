using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BankingSystem.EntityLayer.Models;

public partial class BankingDbContext : DbContext
{
    public BankingDbContext(DbContextOptions<BankingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Account { get; set; }

    public virtual DbSet<Branch> Branch { get; set; }

    public virtual DbSet<Customer> Customer { get; set; }

    public virtual DbSet<Log> Log { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Transaction> Transaction { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Accountid).HasName("account_pkey");

            entity.ToTable("account");

            entity.Property(e => e.Accountid).HasColumnName("accountid");
            entity.Property(e => e.Accountbalance)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0.00")
                .HasColumnName("accountbalance");
            entity.Property(e => e.Accountcurrency)
                .HasMaxLength(10)
                .HasColumnName("accountcurrency");
            entity.Property(e => e.Accountiban)
                .HasMaxLength(34)
                .HasColumnName("accountiban");
            entity.Property(e => e.Accounttype)
                .HasMaxLength(50)
                .HasColumnName("accounttype");
            entity.Property(e => e.Customertc)
                .HasMaxLength(11)
                .HasColumnName("customertc");

            entity.HasOne(d => d.CustomertcNavigation).WithMany(p => p.Account)
                .HasForeignKey(d => d.Customertc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("account_customertc_fkey");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Branchid).HasName("branch_pkey");

            entity.ToTable("branch");

            entity.Property(e => e.Branchid).HasColumnName("branchid");
            entity.Property(e => e.Branchcity)
                .HasMaxLength(50)
                .HasColumnName("branchcity");
            entity.Property(e => e.Branchname)
                .HasMaxLength(50)
                .HasColumnName("branchname");
            entity.Property(e => e.Branchpostcode)
                .HasMaxLength(10)
                .HasColumnName("branchpostcode");
            entity.Property(e => e.Branchstreet)
                .HasMaxLength(50)
                .HasColumnName("branchstreet");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Customertc).HasName("customer_pkey");

            entity.ToTable("customer");

            entity.Property(e => e.Customertc)
                .HasMaxLength(11)
                .HasColumnName("customertc");
            entity.Property(e => e.Customeraddress).HasColumnName("customeraddress");
            entity.Property(e => e.Customerfname)
                .HasMaxLength(50)
                .HasColumnName("customerfname");
            entity.Property(e => e.Customerlname)
                .HasMaxLength(50)
                .HasColumnName("customerlname");
            entity.Property(e => e.Customerphone)
                .HasMaxLength(15)
                .HasColumnName("customerphone");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("log_pkey");

            entity.ToTable("log");

            entity.Property(e => e.Logid).HasColumnName("logid");
            entity.Property(e => e.Customertc)
                .HasMaxLength(11)
                .HasColumnName("customertc");
            entity.Property(e => e.Logdatetime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("logdatetime");
            entity.Property(e => e.Logtype)
                .HasMaxLength(50)
                .HasColumnName("logtype");
            entity.Property(e => e.Newbalance)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0.00")
                .HasColumnName("newbalance");
            entity.Property(e => e.Oldbalance)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0.00")
                .HasColumnName("oldbalance");
            entity.Property(e => e.Stafftc)
                .HasMaxLength(11)
                .HasColumnName("stafftc");

            entity.HasOne(d => d.CustomertcNavigation).WithMany(p => p.Log)
                .HasForeignKey(d => d.Customertc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("log_customertc_fkey");

            entity.HasOne(d => d.StafftcNavigation).WithMany(p => p.Log)
                .HasForeignKey(d => d.Stafftc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("log_stafftc_fkey");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Stafftc).HasName("staff_pkey");

            entity.ToTable("staff");

            entity.Property(e => e.Stafftc)
                .HasMaxLength(11)
                .HasColumnName("stafftc");
            entity.Property(e => e.Branchid).HasColumnName("branchid");
            entity.Property(e => e.Customertc)
                .HasMaxLength(11)
                .HasColumnName("customertc");
            entity.Property(e => e.Staffaddress).HasColumnName("staffaddress");
            entity.Property(e => e.Staffemail)
                .HasMaxLength(100)
                .HasColumnName("staffemail");
            entity.Property(e => e.Stafffname)
                .HasMaxLength(50)
                .HasColumnName("stafffname");
            entity.Property(e => e.Stafflname)
                .HasMaxLength(50)
                .HasColumnName("stafflname");
            entity.Property(e => e.Staffphone)
                .HasMaxLength(15)
                .HasColumnName("staffphone");
            entity.Property(e => e.Staffposition)
                .HasMaxLength(20)
                .HasColumnName("staffposition");

            entity.HasOne(d => d.Branch).WithMany(p => p.Staff)
                .HasForeignKey(d => d.Branchid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("staff_branchid_fkey");

            entity.HasOne(d => d.CustomertcNavigation).WithMany(p => p.Staff)
                .HasForeignKey(d => d.Customertc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("staff_customertc_fkey");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Transactionid).HasName("transaction_pkey");

            entity.ToTable("transaction");

            entity.Property(e => e.Transactionid).HasColumnName("transactionid");
            entity.Property(e => e.Transactionamount)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("0.00")
                .HasColumnName("transactionamount");
            entity.Property(e => e.Transactiondate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("transactiondate");
            entity.Property(e => e.Transactiondescription).HasColumnName("transactiondescription");
            entity.Property(e => e.Transactionfromtc)
                .HasMaxLength(11)
                .HasColumnName("transactionfromtc");
            entity.Property(e => e.Transactiontotc)
                .HasMaxLength(11)
                .HasColumnName("transactiontotc");

            entity.HasOne(d => d.TransactionfromtcNavigation).WithMany(p => p.TransactionTransactionfromtcNavigation)
                .HasForeignKey(d => d.Transactionfromtc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_transactionfromtc_fkey");

            entity.HasOne(d => d.TransactiontotcNavigation).WithMany(p => p.TransactionTransactiontotcNavigation)
                .HasForeignKey(d => d.Transactiontotc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_transactiontotc_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
