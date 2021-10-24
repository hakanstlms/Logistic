﻿// <auto-generated />
using System;
using HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HekaLojisticsApp.DataAccess.Migrations
{
    [DbContext(typeof(LojistikAppContext))]
    partial class LojistikAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HekaLojisticsApp.Entities.Concrete.Order.OrderEntity", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Approval")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BuyerCompanyId")
                        .HasColumnType("int");

                    b.Property<bool>("Cancel")
                        .HasColumnType("bit");

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CurrencyCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<DateTime>("DeadlineDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntryCustomsCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<int>("ExitCustomsCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<string>("InvoiceStatusCode")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OrderCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OrderDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("RateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShipperCompanyId")
                        .HasColumnType("int");

                    b.Property<int>("StatusCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalVolume")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransactionDirectionCode")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UploadPointCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<int>("UploadTypeCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<int>("VolumeUnitCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<int>("WeightUnitCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Order", "Order");
                });
#pragma warning restore 612, 618
        }
    }
}
