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
    [Migration("20230820085904_updateQu")]
    partial class updateQu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TirocinioApi.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FK_Question")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("TirocinioApi.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FK_Show")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("TirocinioApi.Models.QuestionResultAnswer", b =>
                {
                    b.Property<int>("IdQuestionResultAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdQuestionResultAnswer"));

                    b.Property<int>("FK_IdAnswer")
                        .HasColumnType("integer");

                    b.Property<int>("FK_IdQuestion")
                        .HasColumnType("integer");

                    b.Property<int>("FK_IdResult")
                        .HasColumnType("integer");

                    b.HasKey("IdQuestionResultAnswer");

                    b.ToTable("QuestionResultAnswer");
                });

            modelBuilder.Entity("TirocinioApi.Models.Result", b =>
                {
                    b.Property<int>("IdShowRealized")
                        .HasColumnType("integer");

                    b.Property<int>("IdUserShow")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("IdShowRealized", "IdUserShow");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("TirocinioApi.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CoverImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Show");
                });

            modelBuilder.Entity("TirocinioApi.Models.ShowRealize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FK_Show")
                        .HasColumnType("integer");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ShowRealize");
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

                    b.HasKey("Id");

                    b.ToTable("UserShow");
                });
#pragma warning restore 612, 618
        }
    }
}
