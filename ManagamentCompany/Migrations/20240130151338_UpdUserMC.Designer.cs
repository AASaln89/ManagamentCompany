﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Net14Web.DbStuff;

#nullable disable

namespace Net14Web.Migrations.ManagementCompanyDb
{
    [DbContext(typeof(ManagementCompanyDbContext))]
    [Migration("20240130151338_UpdUserMC")]
    partial class UpdUserMC
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.MemberPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Permission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MemberPermissions");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.MemberStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MemberStatuses");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("StatusId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MemberPermissionId")
                        .HasColumnType("int");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MemberPermissionId");

                    b.HasIndex("StatusId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.UserTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExecutorId")
                        .HasColumnType("int");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ExecutorId");

                    b.HasIndex("StatusId");

                    b.ToTable("UserTasks");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.UserTaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskStatuses");
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<int>("ExecutorsId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("ExecutorsId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.Company", b =>
                {
                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.MemberStatus", "Status")
                        .WithMany("Companies")
                        .HasForeignKey("StatusId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.Project", b =>
                {
                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.Company", "Company")
                        .WithMany("Projects")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.MemberStatus", "Status")
                        .WithMany("Projects")
                        .HasForeignKey("StatusId");

                    b.Navigation("Company");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.User", b =>
                {
                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.Company", "Company")
                        .WithMany("Executors")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.MemberPermission", "MemberPermission")
                        .WithMany("Users")
                        .HasForeignKey("MemberPermissionId");

                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.MemberStatus", "Status")
                        .WithMany("Users")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("MemberPermission");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.UserTask", b =>
                {
                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.User", "Author")
                        .WithMany("UserCreatedTasks")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.User", "Executor")
                        .WithMany("UserExecutedTasks")
                        .HasForeignKey("ExecutorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.UserTaskStatus", "Status")
                        .WithMany("UserTasks")
                        .HasForeignKey("StatusId");

                    b.Navigation("Author");

                    b.Navigation("Executor");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.User", null)
                        .WithMany()
                        .HasForeignKey("ExecutorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net14Web.DbStuff.ManagementCompany.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.Company", b =>
                {
                    b.Navigation("Executors");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.MemberPermission", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.MemberStatus", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Projects");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.User", b =>
                {
                    b.Navigation("UserCreatedTasks");

                    b.Navigation("UserExecutedTasks");
                });

            modelBuilder.Entity("Net14Web.DbStuff.ManagementCompany.Models.UserTaskStatus", b =>
                {
                    b.Navigation("UserTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
