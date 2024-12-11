using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cseresznye_OACMUT_API.Models
{
    public partial class FitnessDBContext : DbContext
    {
        public FitnessDBContext()
        {
        }

        public FitnessDBContext(DbContextOptions<FitnessDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nutrition> Nutritions { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Workout> Workouts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=oacmut.database.windows.net;Initial Catalog=FitnessDB;User ID=gipszjakab;Password=Password12345;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nutrition>(entity =>
            {
                entity.ToTable("Nutrition");

                entity.Property(e => e.NutritionId).HasColumnName("NutritionID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.MealType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                //entity.HasOne(d => d.Person)
                //    .WithMany(p => p.Nutritions)
                //    .HasForeignKey(d => d.PersonId)
                //    .HasConstraintName("FK__Nutrition__Perso__1DB06A4F");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.Property(e => e.WorkoutId).HasColumnName("WorkoutID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.WorkoutName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Workouts)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Workouts__Person__18EBB532");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
