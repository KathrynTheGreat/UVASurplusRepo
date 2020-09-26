﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UVASurplus.Data;

namespace UVASurplus.Migrations
{
    [DbContext(typeof(UVASurplusContext))]
    [Migration("20200915231544_Recreate2")]
    partial class Recreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UVASurplus.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetTag")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Condition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipmentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RequestID")
                        .HasColumnType("int");

                    b.Property<string>("Serial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RequestID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("UVASurplus.Models.Request", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AdditionalReviewer")
                        .HasColumnType("bit");

                    b.Property<string>("AdditionalReviewerCompID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComputingID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("DesiredDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HealthFunds")
                        .HasColumnType("bit");

                    b.Property<bool>("NeedPickup")
                        .HasColumnType("bit");

                    b.Property<int>("OAward")
                        .HasColumnType("int");

                    b.Property<int>("OOrg")
                        .HasColumnType("int");

                    b.Property<int>("OProject")
                        .HasColumnType("int");

                    b.Property<int>("OTask")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequesterBuilding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequesterDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequesterEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RequesterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RequesterPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequesterRoom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TaggedAssets")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("UVASurplus.Models.Item", b =>
                {
                    b.HasOne("UVASurplus.Models.Request", null)
                        .WithMany("Items")
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
