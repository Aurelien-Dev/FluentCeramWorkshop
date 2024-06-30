﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace Repository.Migrations;

[DbContext(typeof(ApplicationDbContext))]
partial class ApplicationDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.2")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("Domain.Models.MainDomain.Firing", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<double>("CostKwH")
                    .HasColumnType("float");

                b.Property<double>("Duration")
                    .HasColumnType("float");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("TotalKwH")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.ToTable("Firings");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.ImageInstruction", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Comment")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("FileLocation")
                    .HasColumnType("int");

                b.Property<int>("IdProduct")
                    .HasColumnType("int");

                b.Property<bool>("IsFavoriteImage")
                    .HasColumnType("bit");

                b.Property<string>("Url")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UrlMedium")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("IdProduct");

                b.ToTable("ImageInstruction");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.Material", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Comment")
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Cost")
                    .HasColumnType("float");

                b.Property<bool?>("IsHomeMade")
                    .HasColumnType("bit");

                b.Property<string>("Link")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Quantity")
                    .HasColumnType("float");

                b.Property<string>("Reference")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Type")
                    .HasColumnType("int");

                b.Property<int>("UniteMesure")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Materials");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.Product", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<double?>("BottomDiameter")
                    .HasColumnType("float");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("DesignInstruction")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("GlazingInstruction")
                    .HasColumnType("nvarchar(max)");

                b.Property<double?>("Height")
                    .HasColumnType("float");

                b.Property<int>("IdWorkshop")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double?>("Price")
                    .HasColumnType("float");

                b.Property<string>("Reference")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double?>("ShrinkingCoeficient")
                    .HasColumnType("float");

                b.Property<int>("Status")
                    .HasColumnType("int");

                b.Property<double?>("TopDiameter")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.HasIndex("IdWorkshop");

                b.ToTable("Products");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.ProductFiring", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<double>("CostKwH")
                    .HasColumnType("float");

                b.Property<int>("IdFiring")
                    .HasColumnType("int");

                b.Property<int>("IdProduct")
                    .HasColumnType("int");

                b.Property<int>("NumberProducts")
                    .HasColumnType("int");

                b.Property<double>("TotalKwH")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.HasIndex("IdFiring");

                b.HasIndex("IdProduct");

                b.ToTable("ProductFirings");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.ProductMaterial", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<double>("Cost")
                    .HasColumnType("float");

                b.Property<int>("IdMaterial")
                    .HasColumnType("int");

                b.Property<int>("IdProduct")
                    .HasColumnType("int");

                b.Property<double>("Quantity")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.HasIndex("IdMaterial");

                b.HasIndex("IdProduct");

                b.ToTable("ProductMaterials");
            });

        modelBuilder.Entity("Domain.Models.WorkshopDomaine.Workshop", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Culture")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Logo")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("PasswordHash")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<byte[]>("Salt")
                    .IsRequired()
                    .HasColumnType("varbinary(max)");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Workshops");
            });

        modelBuilder.Entity("Domain.Models.WorkshopDomaine.WorkshopParameter", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Key")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Value")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("WorkshopId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("WorkshopId");

                b.ToTable("WorkshopParameters");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.ImageInstruction", b =>
            {
                b.HasOne("Domain.Models.MainDomain.Product", "ProductAssociate")
                    .WithMany("ImageInstructions")
                    .HasForeignKey("IdProduct")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("ProductAssociate");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.Product", b =>
            {
                b.HasOne("Domain.Models.WorkshopDomaine.Workshop", "Workshop")
                    .WithMany("Products")
                    .HasForeignKey("IdWorkshop")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Workshop");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.ProductFiring", b =>
            {
                b.HasOne("Domain.Models.MainDomain.Firing", "Firing")
                    .WithMany("ProductFiring")
                    .HasForeignKey("IdFiring")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Domain.Models.MainDomain.Product", "Product")
                    .WithMany("ProductFiring")
                    .HasForeignKey("IdProduct")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Firing");

                b.Navigation("Product");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.ProductMaterial", b =>
            {
                b.HasOne("Domain.Models.MainDomain.Material", "Material")
                    .WithMany("ProductMaterial")
                    .HasForeignKey("IdMaterial")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Domain.Models.MainDomain.Product", "Product")
                    .WithMany("ProductMaterial")
                    .HasForeignKey("IdProduct")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Material");

                b.Navigation("Product");
            });

        modelBuilder.Entity("Domain.Models.WorkshopDomaine.WorkshopParameter", b =>
            {
                b.HasOne("Domain.Models.WorkshopDomaine.Workshop", "Workshop")
                    .WithMany("WorkshopParameters")
                    .HasForeignKey("WorkshopId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Workshop");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.Firing", b =>
            {
                b.Navigation("ProductFiring");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.Material", b =>
            {
                b.Navigation("ProductMaterial");
            });

        modelBuilder.Entity("Domain.Models.MainDomain.Product", b =>
            {
                b.Navigation("ImageInstructions");

                b.Navigation("ProductFiring");

                b.Navigation("ProductMaterial");
            });

        modelBuilder.Entity("Domain.Models.WorkshopDomaine.Workshop", b =>
            {
                b.Navigation("Products");

                b.Navigation("WorkshopParameters");
            });
#pragma warning restore 612, 618
    }
}
