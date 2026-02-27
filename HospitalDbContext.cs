using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;

namespace WPF.Hospital.Repository
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctor { get; set; }

        public DbSet<History> History { get; set; }

        public DbSet<Medicine> Medicine { get; set; }

        public DbSet<Prescription> Prescription { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<History>()
                .HasOne(h => h.PatientId)
                .WithMany(p => p.History)
                .HasForeignKey(h => h.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<History>()
                .HasOne(h => h.DoctorId)
                .WithMany(d => d.History)
                .HasForeignKey(h => h.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Prescription>()
                .HasOne(p => p.HistoryId)
                .WithMany(h => h.Prescription)
                .HasForeignKey(p => p.HistoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Prescription>()
                .HasOne(p => p.MedicineId)
                .WithMany(m => m.Prescription)
                .HasForeignKey(p => p.MedicineId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Medicine>()
                .HasIndex(m => new { m.Name, m.Brand })
                .IsUnique();

            modelBuilder.Entity<Patient>()
                .HasIndex(p => new { p.FirstName, p.LastName, p.Birthdate })
                .IsUnique();
        }
    }
}
