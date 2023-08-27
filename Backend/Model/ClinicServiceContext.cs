//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace Backend;

//public partial class ClinicServiceContext : DbContext
//{
//    public ClinicServiceContext()
//    {
//    }

//    public ClinicServiceContext(DbContextOptions<ClinicServiceContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<Analyser> Analysers { get; set; }

//    public virtual DbSet<Clinika> Clinikas { get; set; }

//    public virtual DbSet<Clinikqueue> Clinikqueues { get; set; }

//    public virtual DbSet<Doctor> Doctors { get; set; }

//    public virtual DbSet<Medservice> Medservices { get; set; }

//    public virtual DbSet<Person> People { get; set; }

//    public virtual DbSet<Role> Roles { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=ClinicService");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Analyser>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("analyser_pkey");

//            entity.HasOne(d => d.Person).WithMany(p => p.Analysers)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_person_id");
//        });

//        modelBuilder.Entity<Clinika>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("clinika_pkey");
//        });

//        modelBuilder.Entity<Clinikqueue>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("clinikqueue_pkey");

//            entity.HasOne(d => d.Doctor).WithMany(p => p.Clinikqueues)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_doctor_id");

//            entity.HasOne(d => d.Person).WithMany(p => p.Clinikqueues)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_person_id");
//        });

//        modelBuilder.Entity<Doctor>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("doctor_pkey");

//            entity.HasOne(d => d.Medservice).WithMany(p => p.Doctors)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_medservice_id");

//            entity.HasOne(d => d.Person).WithMany(p => p.Doctors)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_person_id");
//        });

//        modelBuilder.Entity<Medservice>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("medservice_pkey");

//            entity.HasOne(d => d.Clinika).WithMany(p => p.Medservices)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_clinika_id");
//        });

//        modelBuilder.Entity<Person>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("person_pkey");

//            entity.HasOne(d => d.Clinika).WithMany(p => p.People)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_clinika_id");

//            entity.HasOne(d => d.Medservice).WithMany(p => p.People).HasConstraintName("fk_medservice_id");

//            entity.HasOne(d => d.Role).WithMany(p => p.People)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_role_id");
//        });

//        modelBuilder.Entity<Role>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("role_pkey");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
