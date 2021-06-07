﻿// <auto-generated />
using System;
using CloudComputing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CloudComputing.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210607042951_update app table")]
    partial class updateapptable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("CloudComputing.Model.Application", b =>
                {
                    b.Property<int>("appid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("appid");

                    b.Property<string>("appname")
                        .HasColumnType("longtext")
                        .HasColumnName("appname");

                    b.Property<DateTime>("expire")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("expire");

                    b.Property<string>("image")
                        .HasColumnType("longtext")
                        .HasColumnName("image");

                    b.Property<string>("ip")
                        .HasColumnType("longtext")
                        .HasColumnName("ip");

                    b.Property<int>("port")
                        .HasColumnType("int")
                        .HasColumnName("port");

                    b.Property<int>("readyReplicas")
                        .HasColumnType("int")
                        .HasColumnName("readyReplicas");

                    b.Property<int>("replicas")
                        .HasColumnType("int")
                        .HasColumnName("replicas");

                    b.Property<int>("targetport")
                        .HasColumnType("int")
                        .HasColumnName("targetport");

                    b.Property<string>("username")
                        .HasColumnType("longtext")
                        .HasColumnName("username");

                    b.HasKey("appid");

                    b.ToTable("application");
                });

            modelBuilder.Entity("CloudComputing.Model.Balance", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("username");

                    b.Property<double>("amount")
                        .HasColumnType("double")
                        .HasColumnName("amount");

                    b.HasKey("username");

                    b.ToTable("balance");
                });

            modelBuilder.Entity("CloudComputing.Model.Server", b =>
                {
                    b.Property<int>("serverid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("serverid");

                    b.Property<int>("bandwidth")
                        .HasColumnType("int")
                        .HasColumnName("bandwidth");

                    b.Property<int>("cpu")
                        .HasColumnType("int")
                        .HasColumnName("cpu");

                    b.Property<int>("disk")
                        .HasColumnType("int")
                        .HasColumnName("disk");

                    b.Property<DateTime>("expire")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("expire");

                    b.Property<string>("ip")
                        .HasColumnType("longtext")
                        .HasColumnName("ip");

                    b.Property<float>("memory")
                        .HasColumnType("float")
                        .HasColumnName("memory");

                    b.Property<string>("os")
                        .HasColumnType("longtext")
                        .HasColumnName("os");

                    b.Property<string>("servername")
                        .HasColumnType("longtext")
                        .HasColumnName("servername");

                    b.Property<string>("state")
                        .HasColumnType("longtext")
                        .HasColumnName("state");

                    b.Property<string>("switchname")
                        .HasColumnType("longtext")
                        .HasColumnName("switchname");

                    b.Property<string>("username")
                        .HasColumnType("longtext")
                        .HasColumnName("username");

                    b.HasKey("serverid");

                    b.ToTable("server");
                });

            modelBuilder.Entity("CloudComputing.Model.Switch", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("virtualswitch")
                        .HasColumnType("longtext")
                        .HasColumnName("virtualswitch");

                    b.HasKey("name");

                    b.ToTable("switch");
                });

            modelBuilder.Entity("CloudComputing.Model.Template", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("path")
                        .HasColumnType("longtext")
                        .HasColumnName("path");

                    b.HasKey("name");

                    b.ToTable("template");
                });

            modelBuilder.Entity("CloudComputing.Model.Transaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<double>("amount")
                        .HasColumnType("double")
                        .HasColumnName("amount");

                    b.Property<string>("note")
                        .HasColumnType("longtext")
                        .HasColumnName("note");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("time");

                    b.Property<string>("type")
                        .HasColumnType("longtext")
                        .HasColumnName("type");

                    b.Property<string>("username")
                        .HasColumnType("longtext")
                        .HasColumnName("username");

                    b.HasKey("id");

                    b.ToTable("transaction");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}