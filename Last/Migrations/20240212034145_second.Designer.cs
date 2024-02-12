﻿// <auto-generated />
using System;
using Last.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Last.Migrations
{
    [DbContext(typeof(LastContext))]
    [Migration("20240212034145_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Last.Models.Oborudovanie", b =>
                {
                    b.Property<int>("IdObor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_obor");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdObor"), 1L, 1);

                    b.Property<string>("TitleObor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Title_obor");

                    b.HasKey("IdObor");

                    b.ToTable("Oborudovanie", (string)null);
                });

            modelBuilder.Entity("Last.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_role");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRole"), 1L, 1);

                    b.Property<string>("Role1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Role");

                    b.HasKey("IdRole");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Last.Models.Status", b =>
                {
                    b.Property<int>("IdStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_status");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStatus"), 1L, 1);

                    b.Property<string>("TitleStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Title_status");

                    b.HasKey("IdStatus");

                    b.ToTable("Status", (string)null);
                });

            modelBuilder.Entity("Last.Models.Type", b =>
                {
                    b.Property<int>("IdType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_type");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdType"), 1L, 1);

                    b.Property<string>("TitleType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Title_type");

                    b.HasKey("IdType");

                    b.ToTable("Type", (string)null);
                });

            modelBuilder.Entity("Last.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_user");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"), 1L, 1);

                    b.Property<string>("Fio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FIO");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("IdUser");

                    b.HasIndex("RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Last.Models.Zayavki", b =>
                {
                    b.Property<int>("IdZayavki")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_zayavki");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdZayavki"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("client_id");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("date")
                        .HasColumnName("Date_end");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("date")
                        .HasColumnName("Date_start");

                    b.Property<DateTime>("DateZayavki")
                        .HasColumnType("date")
                        .HasColumnName("Date_zayavki");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("description");

                    b.Property<int>("OborId")
                        .HasColumnType("int")
                        .HasColumnName("obor_id");

                    b.Property<int?>("RabId")
                        .HasColumnType("int")
                        .HasColumnName("rab_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<int>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("type_id");

                    b.HasKey("IdZayavki");

                    b.HasIndex("ClientId");

                    b.HasIndex("OborId");

                    b.HasIndex("RabId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("Zayavki", (string)null);
                });

            modelBuilder.Entity("Last.Models.User", b =>
                {
                    b.HasOne("Last.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_User_Role");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Last.Models.Zayavki", b =>
                {
                    b.HasOne("Last.Models.User", "Client")
                        .WithMany("ZayavkiClients")
                        .HasForeignKey("ClientId")
                        .IsRequired()
                        .HasConstraintName("FK_Zayavki_User1");

                    b.HasOne("Last.Models.Oborudovanie", "Obor")
                        .WithMany("Zayavkis")
                        .HasForeignKey("OborId")
                        .IsRequired()
                        .HasConstraintName("FK_Zayavki_Oborudovanie");

                    b.HasOne("Last.Models.User", "Rab")
                        .WithMany("ZayavkiRabs")
                        .HasForeignKey("RabId")
                        .HasConstraintName("FK_Zayavki_User");

                    b.HasOne("Last.Models.Status", "Status")
                        .WithMany("Zayavkis")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_Zayavki_Status");

                    b.HasOne("Last.Models.Type", "Type")
                        .WithMany("Zayavkis")
                        .HasForeignKey("TypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Zayavki_Type");

                    b.Navigation("Client");

                    b.Navigation("Obor");

                    b.Navigation("Rab");

                    b.Navigation("Status");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Last.Models.Oborudovanie", b =>
                {
                    b.Navigation("Zayavkis");
                });

            modelBuilder.Entity("Last.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Last.Models.Status", b =>
                {
                    b.Navigation("Zayavkis");
                });

            modelBuilder.Entity("Last.Models.Type", b =>
                {
                    b.Navigation("Zayavkis");
                });

            modelBuilder.Entity("Last.Models.User", b =>
                {
                    b.Navigation("ZayavkiClients");

                    b.Navigation("ZayavkiRabs");
                });
#pragma warning restore 612, 618
        }
    }
}
