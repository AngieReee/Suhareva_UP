using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Suhareva_UP.Models;

public partial class _43pSuharevaUpContext : DbContext
{
    public _43pSuharevaUpContext()
    {
    }

    public _43pSuharevaUpContext(DbContextOptions<_43pSuharevaUpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Materialstype> Materialstypes { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Partnersproduct> Partnersproducts { get; set; }

    public virtual DbSet<Partnerssalespoint> Partnerssalespoints { get; set; }

    public virtual DbSet<Partnerstype> Partnerstypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Productsmaterial> Productsmaterials { get; set; }

    public virtual DbSet<Productstype> Productstypes { get; set; }

    public virtual DbSet<Salespoint> Salespoints { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=43P_Suhareva_up;Username=postgres;Password=12345");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Material1).HasName("materials_pkey");

            entity.ToTable("materials");

            entity.Property(e => e.Material1)
                .UseIdentityAlwaysColumn()
                .HasColumnName("material");
            entity.Property(e => e.Materialtypeid).HasColumnName("materialtypeid");
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .HasColumnName("title");

            entity.HasOne(d => d.Materialtype).WithMany(p => p.Materials)
                .HasForeignKey(d => d.Materialtypeid)
                .HasConstraintName("materials_materialtypeid_fkey");
        });

        modelBuilder.Entity<Materialstype>(entity =>
        {
            entity.HasKey(e => e.Materialtypeid).HasName("materialstype_pkey");

            entity.ToTable("materialstype");

            entity.Property(e => e.Materialtypeid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("materialtypeid");
            entity.Property(e => e.Perofdefects).HasColumnName("perofdefects");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Partnersid).HasName("partners_pkey");

            entity.ToTable("partners");

            entity.Property(e => e.Partnersid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("partnersid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Head)
                .HasMaxLength(150)
                .HasColumnName("head");
            entity.Property(e => e.Inn)
                .HasMaxLength(100)
                .HasColumnName("inn");
            entity.Property(e => e.Legaladdress)
                .HasMaxLength(300)
                .HasColumnName("legaladdress");
            entity.Property(e => e.Logo)
                .HasMaxLength(300)
                .HasColumnName("logo");
            entity.Property(e => e.Partnerstypeid).HasColumnName("partnerstypeid");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(30)
                .HasColumnName("phonenumber");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");

            entity.HasOne(d => d.Partnerstype).WithMany(p => p.Partners)
                .HasForeignKey(d => d.Partnerstypeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("partners_partnerstypeid_fkey");
        });

        modelBuilder.Entity<Partnersproduct>(entity =>
        {
            entity.HasKey(e => e.Partnersproductsid).HasName("partnersproducts_pkey");

            entity.ToTable("partnersproducts");

            entity.Property(e => e.Partnersproductsid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("partnersproductsid");
            entity.Property(e => e.Numberofproducts).HasColumnName("numberofproducts");
            entity.Property(e => e.Partnersid).HasColumnName("partnersid");
            entity.Property(e => e.Productsid).HasColumnName("productsid");
            entity.Property(e => e.Saledate).HasColumnName("saledate");

            entity.HasOne(d => d.Partners).WithMany(p => p.Partnersproducts)
                .HasForeignKey(d => d.Partnersid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("partnersproducts_partnersid_fkey");

            entity.HasOne(d => d.Products).WithMany(p => p.Partnersproducts)
                .HasForeignKey(d => d.Productsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("partnersproducts_productsid_fkey");
        });

        modelBuilder.Entity<Partnerssalespoint>(entity =>
        {
            entity.HasKey(e => e.Partnerssalespointsid).HasName("partnerssalespoints_pkey");

            entity.ToTable("partnerssalespoints");

            entity.Property(e => e.Partnerssalespointsid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("partnerssalespointsid");
            entity.Property(e => e.Partnersid).HasColumnName("partnersid");
            entity.Property(e => e.Salepoint).HasColumnName("salepoint");

            entity.HasOne(d => d.Partners).WithMany(p => p.Partnerssalespoints)
                .HasForeignKey(d => d.Partnersid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("partnerssalespoints_partnersid_fkey");

            entity.HasOne(d => d.SalepointNavigation).WithMany(p => p.Partnerssalespoints)
                .HasForeignKey(d => d.Salepoint)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("partnerssalespoints_salepoint_fkey");
        });

        modelBuilder.Entity<Partnerstype>(entity =>
        {
            entity.HasKey(e => e.Partnerstypeid).HasName("partnerstype_pkey");

            entity.ToTable("partnerstype");

            entity.Property(e => e.Partnerstypeid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("partnerstypeid");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Productid).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Productid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("productid");
            entity.Property(e => e.Article)
                .HasMaxLength(30)
                .HasColumnName("article");
            entity.Property(e => e.Description)
                .HasMaxLength(600)
                .HasColumnName("description");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Mincostforpartner).HasColumnName("mincostforpartner");
            entity.Property(e => e.Productimage)
                .HasMaxLength(300)
                .HasColumnName("productimage");
            entity.Property(e => e.Producttype).HasColumnName("producttype");
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .HasColumnName("title");
            entity.Property(e => e.Width).HasColumnName("width");

            entity.HasOne(d => d.ProducttypeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Producttype)
                .HasConstraintName("products_producttype_fkey");
        });

        modelBuilder.Entity<Productsmaterial>(entity =>
        {
            entity.HasKey(e => e.Productsmaterialsid).HasName("productsmaterials_pkey");

            entity.ToTable("productsmaterials");

            entity.Property(e => e.Productsmaterialsid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("productsmaterialsid");
            entity.Property(e => e.Materialid).HasColumnName("materialid");
            entity.Property(e => e.Productid).HasColumnName("productid");

            entity.HasOne(d => d.Material).WithMany(p => p.Productsmaterials)
                .HasForeignKey(d => d.Materialid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productsmaterials_materialid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.Productsmaterials)
                .HasForeignKey(d => d.Productid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productsmaterials_productid_fkey");
        });

        modelBuilder.Entity<Productstype>(entity =>
        {
            entity.HasKey(e => e.Producttypeid).HasName("productstype_pkey");

            entity.ToTable("productstype");

            entity.Property(e => e.Producttypeid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("producttypeid");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Salespoint>(entity =>
        {
            entity.HasKey(e => e.Salepointsid).HasName("salespoints_pkey");

            entity.ToTable("salespoints");

            entity.Property(e => e.Salepointsid)
                .UseIdentityAlwaysColumn()
                .HasColumnName("salepointsid");
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .HasColumnName("address");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
