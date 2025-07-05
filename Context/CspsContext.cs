using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using backend.Models;

namespace backend.Context;

public partial class CspsContext : DbContext
{
    public CspsContext()
    {
    }

    public CspsContext(DbContextOptions<CspsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Announcement> Announcements { get; set; }

    public virtual DbSet<Atillo> Atillos { get; set; }

    public virtual DbSet<College> Colleges { get; set; }

    public virtual DbSet<CollegesCourse> CollegesCourses { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<EditLog> EditLogs { get; set; }

    public virtual DbSet<Env> Envs { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Ict2024Account> Ict2024Accounts { get; set; }

    public virtual DbSet<Ict2024Campus> Ict2024Campuses { get; set; }

    public virtual DbSet<Ict2024Course> Ict2024Courses { get; set; }

    public virtual DbSet<Ict2024DiscountCode> Ict2024DiscountCodes { get; set; }

    public virtual DbSet<Ict2024Student> Ict2024Students { get; set; }

    public virtual DbSet<Ict2024TshirtSize> Ict2024TshirtSizes { get; set; }

    public virtual DbSet<LoginLog> LoginLogs { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<PhotosGcash> PhotosGcashes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductVariation> ProductVariations { get; set; }

    public virtual DbSet<ResetToken> ResetTokens { get; set; }

    public virtual DbSet<Roginand> Roginands { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentsGuest> StudentsGuests { get; set; }

    public virtual DbSet<Tatakform> Tatakforms { get; set; }

    public virtual DbSet<TatakformsAdmin> TatakformsAdmins { get; set; }

    public virtual DbSet<TatakformsAttendance> TatakformsAttendances { get; set; }

    public virtual DbSet<TatakformsResetToken> TatakformsResetTokens { get; set; }

    public virtual DbSet<TatakformsStudent> TatakformsStudents { get; set; }

    public virtual DbSet<Tutorial> Tutorials { get; set; }

    public virtual DbSet<Variation> Variations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("MY_CONN_STRING"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("11.7.2-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Announcement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Atillo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<College>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<CollegesCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<EditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Env>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Ict2024Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Ict2024Campus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Ict2024Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Ict2024DiscountCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Ict2024Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Ict2024TshirtSize>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<LoginLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.ModeOfPayment).HasComment("1=Walk-in,2=GCash");
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<PhotosGcash>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<ProductVariation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<ResetToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Roginand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<StudentsGuest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Tatakform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TatakformsAdmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TatakformsAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TatakformsResetToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TatakformsStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Tutorial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.DateStamp).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.Status).HasDefaultValueSql("'Pending'");
            entity.Property(e => e.StatusDateStamp).HasDefaultValueSql("current_timestamp()");
        });

        modelBuilder.Entity<Variation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
