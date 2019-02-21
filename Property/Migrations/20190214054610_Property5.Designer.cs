﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Property.DataContext;

namespace Property.Migrations
{
    [DbContext(typeof(PropertyDbContext))]
    [Migration("20190214054610_Property5")]
    partial class Property5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Property.Models.Board", b =>
                {
                    b.Property<int>("BoardNo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BoardContent");

                    b.Property<string>("BoardTitle");

                    b.Property<int>("UserNo");

                    b.HasKey("BoardNo");

                    b.HasIndex("UserNo");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("Property.Models.User", b =>
                {
                    b.Property<int>("UserNo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Level");

                    b.Property<string>("UserAddress")
                        .IsRequired();

                    b.Property<string>("UserBirth")
                        .IsRequired();

                    b.Property<string>("UserEmail")
                        .IsRequired();

                    b.Property<string>("UserGender")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<DateTime>("UserInsertDate");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserPhone")
                        .IsRequired();

                    b.Property<string>("UserPw")
                        .IsRequired();

                    b.HasKey("UserNo");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Property.Models.Board", b =>
                {
                    b.HasOne("Property.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserNo")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}