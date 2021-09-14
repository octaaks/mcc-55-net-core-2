﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCore.Context;

namespace NETCore.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NETCore.Models.Account", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIK");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("NETCore.Models.AccountRole", b =>
                {
                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("AccountId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AccountsRoles");
                });

            modelBuilder.Entity("NETCore.Models.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("EducationId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("NETCore.Models.Person", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.HasKey("NIK");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("NETCore.Models.Profiling", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.HasKey("NIK");

                    b.HasIndex("EducationId");

                    b.ToTable("Profilings");
                });

            modelBuilder.Entity("NETCore.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("NETCore.Models.University", b =>
                {
                    b.Property<int>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UniversityId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("NETCore.Models.Account", b =>
                {
                    b.HasOne("NETCore.Models.Person", "Person")
                        .WithOne("Account")
                        .HasForeignKey("NETCore.Models.Account", "NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("NETCore.Models.AccountRole", b =>
                {
                    b.HasOne("NETCore.Models.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NETCore.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("NETCore.Models.Education", b =>
                {
                    b.HasOne("NETCore.Models.University", "Universities")
                        .WithMany("Educations")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Universities");
                });

            modelBuilder.Entity("NETCore.Models.Profiling", b =>
                {
                    b.HasOne("NETCore.Models.Education", "Educations")
                        .WithMany("Profilings")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NETCore.Models.Account", "Account")
                        .WithOne("Profiling")
                        .HasForeignKey("NETCore.Models.Profiling", "NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Educations");
                });

            modelBuilder.Entity("NETCore.Models.Account", b =>
                {
                    b.Navigation("AccountRoles");

                    b.Navigation("Profiling");
                });

            modelBuilder.Entity("NETCore.Models.Education", b =>
                {
                    b.Navigation("Profilings");
                });

            modelBuilder.Entity("NETCore.Models.Person", b =>
                {
                    b.Navigation("Account");
                });

            modelBuilder.Entity("NETCore.Models.Role", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("NETCore.Models.University", b =>
                {
                    b.Navigation("Educations");
                });
#pragma warning restore 612, 618
        }
    }
}
