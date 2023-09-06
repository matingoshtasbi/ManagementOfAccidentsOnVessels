﻿// <auto-generated />
using System;
using ManagementOfAccidentsOnVessels.Infrastructure.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagementOfAccidentsOnVessels.Migrations
{
    [DbContext(typeof(ManagementOfAccidentsOnVesselsDbContext))]
    partial class ManagementOfAccidentsOnVesselsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ManagementOfAccidentsOnVessels.Domain.PortsManagement.Aggregates.Port", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Lon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ports");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Capacity = 4,
                            Lat = 83m,
                            Lon = 79m,
                            Name = "اروندکنار"
                        },
                        new
                        {
                            Id = 2L,
                            Capacity = 8,
                            Lat = 171m,
                            Lon = 43m,
                            Name = "ماهشهر"
                        },
                        new
                        {
                            Id = 3L,
                            Capacity = 3,
                            Lat = 261m,
                            Lon = 54m,
                            Name = "دیلم"
                        },
                        new
                        {
                            Id = 4L,
                            Capacity = 3,
                            Lat = 313m,
                            Lon = 106m,
                            Name = "گناوه"
                        },
                        new
                        {
                            Id = 5L,
                            Capacity = 4,
                            Lat = 288m,
                            Lon = 143m,
                            Name = "خارگ"
                        },
                        new
                        {
                            Id = 6L,
                            Capacity = 4,
                            Lat = 327m,
                            Lon = 134m,
                            Name = "ریگ"
                        },
                        new
                        {
                            Id = 7L,
                            Capacity = 12,
                            Lat = 355m,
                            Lon = 172m,
                            Name = "بوشهر"
                        },
                        new
                        {
                            Id = 8L,
                            Capacity = 3,
                            Lat = 381m,
                            Lon = 212m,
                            Name = "بوالخیر"
                        },
                        new
                        {
                            Id = 9L,
                            Capacity = 4,
                            Lat = 469m,
                            Lon = 246m,
                            Name = "کنگان"
                        },
                        new
                        {
                            Id = 10L,
                            Capacity = 3,
                            Lat = 529m,
                            Lon = 263m,
                            Name = "نخل تقی"
                        },
                        new
                        {
                            Id = 11L,
                            Capacity = 9,
                            Lat = 573m,
                            Lon = 267m,
                            Name = "عسلویه"
                        },
                        new
                        {
                            Id = 12L,
                            Capacity = 8,
                            Lat = 685m,
                            Lon = 349m,
                            Name = "آفتاب"
                        },
                        new
                        {
                            Id = 13L,
                            Capacity = 9,
                            Lat = 664m,
                            Lon = 371m,
                            Name = "کیش"
                        },
                        new
                        {
                            Id = 14L,
                            Capacity = 7,
                            Lat = 824m,
                            Lon = 365m,
                            Name = "شهید رجایی"
                        },
                        new
                        {
                            Id = 15L,
                            Capacity = 5,
                            Lat = 881m,
                            Lon = 362m,
                            Name = "لافت"
                        },
                        new
                        {
                            Id = 16L,
                            Capacity = 3,
                            Lat = 864m,
                            Lon = 435m,
                            Name = "ابوموسی"
                        },
                        new
                        {
                            Id = 17L,
                            Capacity = 6,
                            Lat = 928m,
                            Lon = 325m,
                            Name = "حقانی"
                        },
                        new
                        {
                            Id = 18L,
                            Capacity = 11,
                            Lat = 941m,
                            Lon = 360m,
                            Name = "قشم"
                        });
                });

            modelBuilder.Entity("ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates.Vessel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxSpeed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PortId")
                        .HasColumnType("bigint");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VesselTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vessels");
                });

            modelBuilder.Entity("ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates.Vessel", b =>
                {
                    b.OwnsOne("ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates.VesselExtraDetail", "Detail", b1 =>
                        {
                            b1.Property<long>("VesselId")
                                .HasColumnType("bigint");

                            b1.Property<string>("BodyMaterial")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int?>("Capacity")
                                .HasColumnType("int");

                            b1.Property<string>("EngineModel")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ManufacturerCountry")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ManufacturerName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("VesselId");

                            b1.ToTable("Vessels");

                            b1.WithOwner()
                                .HasForeignKey("VesselId");
                        });

                    b.Navigation("Detail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
