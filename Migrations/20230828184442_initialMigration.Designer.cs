﻿// <auto-generated />
using System;
using ManagementOfAccidentsOnVessels.Infrastructure.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagementOfAccidentsOnVessels.Migrations
{
    [DbContext(typeof(ManagementOfAccidentsOnVesselsDbContext))]
    [Migration("20230828184442_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
