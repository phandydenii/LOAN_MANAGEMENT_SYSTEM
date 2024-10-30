﻿// <auto-generated />
using System;
using LOAN_MANAGEMENT_API.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LOAN_MANAGEMENT_API.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LOAN_MANAGEMENT_API.Model.LoanType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("tbl_loan_type");
                });

            modelBuilder.Entity("LOAN_MANAGEMENT_API.Model.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("dateadd")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expiredate")
                        .HasColumnType("datetime2");

                    b.Property<string>("fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("user_tbl");
                });

            modelBuilder.Entity("Namespace.Borrow", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("contact_name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("first_name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("last_name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("tbl_borrow");
                });

            modelBuilder.Entity("Namespace.Loan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.Property<int>("borrow_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_release")
                        .HasColumnType("datetime2");

                    b.Property<int>("plan_id")
                        .HasColumnType("int");

                    b.Property<string>("purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("references_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("type_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_loan");
                });

            modelBuilder.Entity("Namespace.LoanPlan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<float>("interest")
                        .HasColumnType("real");

                    b.Property<int>("month")
                        .HasColumnType("int");

                    b.Property<int>("penalty")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_loan_plan");
                });

            modelBuilder.Entity("Namespace.LoanSchedule", b =>
                {
                    b.Property<int>("loan_schedule_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("loan_schedule_id"), 1L, 1);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("loan_id")
                        .HasColumnType("int");

                    b.HasKey("loan_schedule_id");

                    b.ToTable("tbl_loan_schedule");
                });

            modelBuilder.Entity("Namespace.Payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("date_create")
                        .HasColumnType("datetime2");

                    b.Property<int>("loan_id")
                        .HasColumnType("int");

                    b.Property<int>("overdue")
                        .HasColumnType("int");

                    b.Property<float>("pay_amount")
                        .HasColumnType("real");

                    b.Property<string>("payee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("penalty")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("tbl_payment");
                });
#pragma warning restore 612, 618
        }
    }
}
