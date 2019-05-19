﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeacherRegister.DAL.EF;

namespace TeacherRegister.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeacherRegister.BLL.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("TeacherRegister.BLL.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId")
                        .IsUnique();

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("TeacherRegister.BLL.Teacher", b =>
                {
                    b.HasOne("TeacherRegister.BLL.Subject", "Subject")
                        .WithOne("Teacher")
                        .HasForeignKey("TeacherRegister.BLL.Teacher", "SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
