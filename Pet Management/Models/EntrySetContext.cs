/************************************************************************
/* Copyright (©) 2019 PETTO SYSTEM
/************************************************************************
/* File Name    : EntrySetContext.cs
/* Function     : Entity data context class
/* Create       : LinhTran 2019/11/11
/************************************************************************/
using Microsoft.EntityFrameworkCore;
using Pet_Management.Models;

public partial class EntrySetContext : DbContext
{
    public EntrySetContext() { }
    public EntrySetContext(DbContextOptions options) :base(options)
    {
    }

    #region Entity

    public DbSet<USER> USER { get; set; }
    public DbSet<PET> PET { get; set; }
    public DbSet<PET_IMG> PET_IMG { get; set; }
    public DbSet<VIDEO> VIDEO { get; set; }
    public DbSet<IMAGE> IMAGE { get; set; }
    public DbSet<PURCHASE> PURCHASE { get; set; }
    public DbSet<PURCHASE_IMG> PURCHASE_IMG { get; set; }
    public DbSet<SCHEDULE> SCHEDULE { get; set; }
    public DbSet<HEALTHCARE> HEALTHCARE { get; set; }


    // Mater Table
    public DbSet<MFURCOLOR> MFURCOLOR { get; set; }
    public DbSet<MSERVICE> MSERVICE { get; set; }
    public DbSet<MPETTYPE> MPETTYPE { get; set; }
    public DbSet<DPETTYPE> DPETTYPE { get; set; }
    public DbSet<MCITY> MCITY { get; set; }
    public DbSet<MDISTRICT> MDISTRICT { get; set; }
    public DbSet<MWARD> MWARD { get; set; }
    #endregion

    #region DB Configuring

    /// <summary>
    /// create model
    /// </summary>
    /// <param name="modelBuilder">model builder</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<USER>().ToTable("USER");
        modelBuilder.Entity<PET_IMG>().ToTable("PET_IMG").HasKey(m => new { m.pet_id, m.img_id });
        modelBuilder.Entity<PET>().ToTable("PET");
        modelBuilder.Entity<VIDEO>().ToTable("VIDEO");
        modelBuilder.Entity<MCITY>().ToTable("MCITY");
        modelBuilder.Entity<MDISTRICT>().ToTable("MDISTRICT");
        modelBuilder.Entity<MWARD>().ToTable("MWARD");
        modelBuilder.Entity<SCHEDULE>().ToTable("SCHEDULE");
        modelBuilder.Entity<MSERVICE>().ToTable("MSERVICE");
        modelBuilder.Entity<MFURCOLOR>().ToTable("MFURCOLOR");
        modelBuilder.Entity<MPETTYPE>().ToTable("MPETTYPE");
        modelBuilder.Entity<DPETTYPE>().ToTable("DPETTYPE");
        modelBuilder.Entity<IMAGE>().ToTable("IMAGE");
        modelBuilder.Entity<PURCHASE>().ToTable("PURCHASE");
        modelBuilder.Entity<HEALTHCARE>().ToTable("HEALTHCARE");
        modelBuilder.Entity<PURCHASE_IMG>().ToTable("PURCHASE_IMG").HasKey(m => new { m.purchase_id, m.img_id });
    }
    #endregion
}