
using application;
using application.Entitys;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistence
{
    public class AppDbContext: IdentityDbContext<User, IdentityRole<int>, int>
    {
           public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Console.WriteLine("=================" + builder);
            builder.Entity<Attendance>(entity =>
            {
                entity.HasOne(attendance => attendance.Doctor)
                    .WithMany(docotr => docotr.Attendances)
                    .HasForeignKey(attendance => attendance.DoctorId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Appointment>(entity =>
            {
                entity.HasOne(appointment => appointment.Patient)
                    .WithMany(patient => patient.Appointments)
                    .HasForeignKey(appointment => appointment.PatientId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //builder.Entity<Appointment>(entity =>
            //{
            //    entity.HasOne(appointment => appointment.Doctor)
            //        .WithMany(patient => patient.Appointments)
            //        .HasForeignKey(appointment => appointment.DoctorId)
            //        .OnDelete(DeleteBehavior.Cascade);
            //});


            base.OnModelCreating(builder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Contract> contracts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
