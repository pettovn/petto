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
    public DbSet<PET_SERVICE> PET_SERVICE { get; set; }


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
        modelBuilder.Entity<PET_IMG>().ToTable("PET_IMG").HasKey(m => new { m.pet_id, m.img_id });
        modelBuilder.Entity<PET_SERVICE>().ToTable("PET_SERVICE").HasKey(m => new { m.pet_id, m.service_id });
        modelBuilder.Entity<PURCHASE_IMG>().ToTable("PURCHASE_IMG").HasKey(m => new { m.purchase_id, m.img_id });
    }
    #endregion
}