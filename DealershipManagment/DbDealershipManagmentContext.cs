using System;
using System.Collections.Generic;
using DealershipManagment.Tables;
using Microsoft.EntityFrameworkCore;

namespace DealershipManagment;

public partial class DbDealershipManagmentContext : DbContext
{
    public DbDealershipManagmentContext()
    {
    }

    public DbDealershipManagmentContext(DbContextOptions<DbDealershipManagmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Mark> Marks { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-N2VCPDG;Initial Catalog=Db_DealershipManagment;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.IdCar);

            entity.Property(e => e.IdCar)
                .ValueGeneratedNever()
                .HasColumnName("id_car");
            entity.Property(e => e.BodyType).HasColumnName("body_type");
            entity.Property(e => e.Drive).HasColumnName("drive");
            entity.Property(e => e.EngineType).HasColumnName("engine_type");
            entity.Property(e => e.MarkId).HasColumnName("mark_id");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.ReleaseYear).HasColumnName("release_year");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Transmission).HasColumnName("transmission");
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .HasColumnName("VIN");

            entity.HasOne(d => d.Mark).WithMany(p => p.Cars)
                .HasForeignKey(d => d.MarkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cars_Marks");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.Property(e => e.IdClient)
                .ValueGeneratedNever()
                .HasColumnName("id_client");
            entity.Property(e => e.Fio)
                .HasMaxLength(75)
                .HasColumnName("fio");
            entity.Property(e => e.Pass)
                .HasMaxLength(10)
                .HasColumnName("pass");
            entity.Property(e => e.TelNum)
                .HasMaxLength(12)
                .HasColumnName("tel_num");
        });

        modelBuilder.Entity<Mark>(entity =>
        {
            entity.HasKey(e => e.IdMark);

            entity.Property(e => e.IdMark)
                .ValueGeneratedNever()
                .HasColumnName("id_mark");
            entity.Property(e => e.NameMark)
                .HasMaxLength(30)
                .HasColumnName("name_mark");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.IdReport);

            entity.Property(e => e.IdReport)
                .ValueGeneratedNever()
                .HasColumnName("id_report");
            entity.Property(e => e.DateReport).HasColumnName("date_report");
            entity.Property(e => e.HoursWork).HasColumnName("hoursWork");
            entity.Property(e => e.MonthReport)
                .HasMaxLength(20)
                .HasColumnName("monthReport");
            entity.Property(e => e.Prize)
                .HasColumnType("money")
                .HasColumnName("prize");
            entity.Property(e => e.Salary)
                .HasColumnType("money")
                .HasColumnName("salary");
            entity.Property(e => e.WorkerId).HasColumnName("worker_id");

            entity.HasOne(d => d.Worker).WithMany(p => p.Reports)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reports_Workers");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.IdRequest);

            entity.Property(e => e.IdRequest)
                .ValueGeneratedNever()
                .HasColumnName("id_request");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.DateEndRepair)
                .HasColumnType("datetime")
                .HasColumnName("dateEndRepair");
            entity.Property(e => e.DateStartRepair)
                .HasColumnType("datetime")
                .HasColumnName("dateStartRepair");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.StatusZayavki).HasColumnName("status_zayavki");

            entity.HasOne(d => d.Car).WithMany(p => p.Requests)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Requests_Cars");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole);

            entity.Property(e => e.IdRole)
                .ValueGeneratedNever()
                .HasColumnName("id_role");
            entity.Property(e => e.NameRole)
                .HasMaxLength(40)
                .HasColumnName("name_role");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.IdSale);

            entity.Property(e => e.IdSale)
                .ValueGeneratedNever()
                .HasColumnName("id_sale");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.DateSale)
                .HasColumnType("datetime")
                .HasColumnName("date_sale");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
            entity.Property(e => e.WorkerId).HasColumnName("worker_id");

            entity.HasOne(d => d.Car).WithMany(p => p.Sales)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Cars");

            entity.HasOne(d => d.Client).WithMany(p => p.Sales)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Clients");

            entity.HasOne(d => d.Worker).WithMany(p => p.Sales)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Workers");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.IdWorker);

            entity.Property(e => e.IdWorker)
                .ValueGeneratedNever()
                .HasColumnName("id_worker");
            entity.Property(e => e.Fio)
                .HasMaxLength(75)
                .HasColumnName("fio");
            entity.Property(e => e.Pass)
                .HasMaxLength(10)
                .HasColumnName("pass");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TelNum)
                .HasMaxLength(12)
                .HasColumnName("tel_num");

            entity.HasOne(d => d.Role).WithMany(p => p.Workers)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Workers_Roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
