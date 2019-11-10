using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Pet_Management;
using Pet_Management.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public partial class EntrySetContext : DbContext
{
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

    /// <summary> Key Setting </summary>
    /// <param name="modelBuilder"></param>
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