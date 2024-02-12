using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Last.Models
{
    public partial class LastContext : DbContext
    {
        public LastContext()
        {
        }

        public LastContext(DbContextOptions<LastContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Oborudovanie> Oborudovanies { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Type> Types { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Zayavki> Zayavkis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ALEXANDER\\SQLEXPRESS;Initial Catalog=Last;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oborudovanie>(entity =>
            {
                entity.HasKey(e => e.IdObor);

                entity.ToTable("Oborudovanie");

                entity.Property(e => e.IdObor).HasColumnName("Id_obor");

                entity.Property(e => e.TitleObor)
                    .HasMaxLength(50)
                    .HasColumnName("Title_obor");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("Role");

                entity.Property(e => e.IdRole).HasColumnName("Id_role");

                entity.Property(e => e.Role1)
                    .HasMaxLength(50)
                    .HasColumnName("Role");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.ToTable("Status");

                entity.Property(e => e.IdStatus).HasColumnName("Id_status");

                entity.Property(e => e.TitleStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Title_status");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.IdType);

                entity.ToTable("Type");

                entity.Property(e => e.IdType).HasColumnName("Id_type");

                entity.Property(e => e.TitleType)
                    .HasMaxLength(50)
                    .HasColumnName("Title_type");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.Fio)
                    .HasMaxLength(100)
                    .HasColumnName("FIO");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .HasColumnName("login");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<Zayavki>(entity =>
            {
                entity.HasKey(e => e.IdZayavki);

                entity.ToTable("Zayavki");

                entity.Property(e => e.IdZayavki).HasColumnName("Id_zayavki");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("Date_end");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("Date_start");

                entity.Property(e => e.DateZayavki)
                    .HasColumnType("date")
                    .HasColumnName("Date_zayavki");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.OborId).HasColumnName("obor_id");

                entity.Property(e => e.RabId).HasColumnName("rab_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ZayavkiClients)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zayavki_User1");

                entity.HasOne(d => d.Obor)
                    .WithMany(p => p.Zayavkis)
                    .HasForeignKey(d => d.OborId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zayavki_Oborudovanie");

                entity.HasOne(d => d.Rab)
                    .WithMany(p => p.ZayavkiRabs)
                    .HasForeignKey(d => d.RabId)
                    .HasConstraintName("FK_Zayavki_User");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Zayavkis)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zayavki_Status");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Zayavkis)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zayavki_Type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
