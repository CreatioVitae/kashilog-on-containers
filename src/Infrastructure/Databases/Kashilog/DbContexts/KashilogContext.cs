using System;
using System.Collections.Generic;
using Database.Kashilog.EntityDataModels;
using Microsoft.EntityFrameworkCore;

namespace Database.Kashilog.DbContexts;

public partial class KashilogContext : DbContext
{
    public KashilogContext(DbContextOptions<KashilogContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CmnCompany> CmnCompanies { get; set; }

    public virtual DbSet<CmnCompanyUserProperty> CmnCompanyUserProperties { get; set; }

    public virtual DbSet<CmnCustomerUserProperty> CmnCustomerUserProperties { get; set; }

    public virtual DbSet<CmnManagementUserProperty> CmnManagementUserProperties { get; set; }

    public virtual DbSet<CmnRole> CmnRoles { get; set; }

    public virtual DbSet<CmnRoleAcl> CmnRoleAcls { get; set; }

    public virtual DbSet<CmnTaste> CmnTastes { get; set; }

    public virtual DbSet<CmnTexture> CmnTextures { get; set; }

    public virtual DbSet<CmnUser> CmnUsers { get; set; }

    public virtual DbSet<CmnUserAuthentication> CmnUserAuthentications { get; set; }

    public virtual DbSet<MstProduct> MstProducts { get; set; }

    public virtual DbSet<MstProductTaste> MstProductTastes { get; set; }

    public virtual DbSet<MstProductTexture> MstProductTextures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Japanese_90_CI_AS");

        modelBuilder.Entity<CmnCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__CmnCompa__2D971CACAE1654EE");

            entity.ToTable("CmnCompany", "enterprise");

            entity.Property(e => e.Address).HasMaxLength(1000);
            entity.Property(e => e.City).HasMaxLength(40);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.TelephoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CmnCompanyUserProperty>(entity =>
        {
            entity.HasKey(e => e.CompanyUserPropertyId);

            entity.ToTable("CmnCompanyUserProperties", "account");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.CmnCompanyUserProperties)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CmnCompanyUserProperties_CmnUsers");
        });

        modelBuilder.Entity<CmnCustomerUserProperty>(entity =>
        {
            entity.HasKey(e => e.CustomerUserPropertyId);

            entity.ToTable("CmnCustomerUserProperties", "account");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.CmnCustomerUserProperties)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CmnCustomerUserProperties_CmnUsers");
        });

        modelBuilder.Entity<CmnManagementUserProperty>(entity =>
        {
            entity.HasKey(e => e.ManagementUserPropertyId);

            entity.ToTable("CmnManagementUserProperties", "account");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.CmnManagementUserProperties)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CmnManagementUserProperties_CmnUsers");
        });

        modelBuilder.Entity<CmnRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("CmnRoles", "account");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.RoleName).HasMaxLength(40);
        });

        modelBuilder.Entity<CmnRoleAcl>(entity =>
        {
            entity.HasKey(e => e.RoleAclId);

            entity.ToTable("CmnRoleAcls", "account");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.CmnRoleAcls)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CmnRoleAcls_CmnRoles");
        });

        modelBuilder.Entity<CmnTaste>(entity =>
        {
            entity.HasKey(e => e.TasteId);

            entity.ToTable("CmnTaste", "kashi");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.TasteName).HasMaxLength(50);
        });

        modelBuilder.Entity<CmnTexture>(entity =>
        {
            entity.HasKey(e => e.TextureId);

            entity.ToTable("CmnTexture", "kashi");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.TextureName).HasMaxLength(50);
        });

        modelBuilder.Entity<CmnUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("CmnUsers", "account");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(120);

            entity.HasOne(d => d.Role).WithMany(p => p.CmnUsers)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CmnUsers_CmnRoles");
        });

        modelBuilder.Entity<CmnUserAuthentication>(entity =>
        {
            entity.HasKey(e => e.UserAuthenticationId);

            entity.ToTable("CmnUserAuthentications", "account");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.HashedPassword).HasMaxLength(256);
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedSign).HasColumnType("datetime");
            entity.Property(e => e.LockoutEndDate).HasColumnType("datetime");
            entity.Property(e => e.LoginName).HasMaxLength(40);

            entity.HasOne(d => d.User).WithMany(p => p.CmnUserAuthentications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CmnUserAuthentications_CmnUsers");
        });

        modelBuilder.Entity<MstProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__MstProdu__B40CC6CDD0E57549");

            entity.ToTable("MstProduct", "kashi");

            entity.HasIndex(e => new { e.ProductLineUpId, e.ProductRevision }, "UK_MstProduct").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.CreatedTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.Revision)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.ValidBeginDateTime).HasColumnType("datetime");
            entity.Property(e => e.ValidEndDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.MakerCompany).WithMany(p => p.MstProductMakerCompanies)
                .HasForeignKey(d => d.MakerCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MstProductMaker_CmnCompany");

            entity.HasOne(d => d.PublisherCompany).WithMany(p => p.MstProductPublisherCompanies)
                .HasForeignKey(d => d.PublisherCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MstProductPublisher_CmnCompany");
        });

        modelBuilder.Entity<MstProductTaste>(entity =>
        {
            entity.HasKey(e => e.ProductTasteId);

            entity.ToTable("MstProductTaste", "kashi");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstProductTexture>(entity =>
        {
            entity.HasKey(e => e.ProductTextureId);

            entity.ToTable("MstProductTexture", "kashi");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
