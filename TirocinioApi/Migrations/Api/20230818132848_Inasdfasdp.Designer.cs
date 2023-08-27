﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TirocinioApi.Data;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    [DbContext(typeof(ApiContext))]
    [Migration("20230818132848_Inasdfasdp")]
    partial class Inasdfasdp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("TirocinioApi.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FK_QuestionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FK_QuestionId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("TirocinioApi.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FK_ShowId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FK_ShowId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("TirocinioApi.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FK_QuestionId")
                        .HasColumnType("integer");

                    b.Property<int>("FK_ShowId")
                        .HasColumnType("integer");

                    b.Property<int>("FK_UserShowId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FK_QuestionId");

                    b.HasIndex("FK_ShowId");

                    b.HasIndex("FK_UserShowId");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("TirocinioApi.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Show");
                });

            modelBuilder.Entity("TirocinioApi.Models.UserShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ResultId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResultId");

                    b.ToTable("UserShow");
                });

            modelBuilder.Entity("TirocinioApi.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("TirocinioApi.Models.Answer", b =>
                {
                    b.HasOne("TirocinioApi.Models.Question", "FK_Question")
                        .WithMany("Answer")
                        .HasForeignKey("FK_QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FK_Question");
                });

            modelBuilder.Entity("TirocinioApi.Models.Question", b =>
                {
                    b.HasOne("TirocinioApi.Models.Show", "FK_Show")
                        .WithMany("Question")
                        .HasForeignKey("FK_ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FK_Show");
                });

            modelBuilder.Entity("TirocinioApi.Models.Result", b =>
                {
                    b.HasOne("TirocinioApi.Models.Question", "FK_Question")
                        .WithMany("Result")
                        .HasForeignKey("FK_QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TirocinioApi.Models.Show", "FK_Show")
                        .WithMany("Result")
                        .HasForeignKey("FK_ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TirocinioApi.Models.UserShow", "FK_UserShow")
                        .WithMany()
                        .HasForeignKey("FK_UserShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FK_Question");

                    b.Navigation("FK_Show");

                    b.Navigation("FK_UserShow");
                });

            modelBuilder.Entity("TirocinioApi.Models.Show", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TirocinioApi.Models.UserShow", b =>
                {
                    b.HasOne("TirocinioApi.Models.Result", null)
                        .WithMany("UserShow")
                        .HasForeignKey("ResultId");
                });

            modelBuilder.Entity("TirocinioApi.Models.Question", b =>
                {
                    b.Navigation("Answer");

                    b.Navigation("Result");
                });

            modelBuilder.Entity("TirocinioApi.Models.Result", b =>
                {
                    b.Navigation("UserShow");
                });

            modelBuilder.Entity("TirocinioApi.Models.Show", b =>
                {
                    b.Navigation("Question");

                    b.Navigation("Result");
                });
#pragma warning restore 612, 618
        }
    }
}
