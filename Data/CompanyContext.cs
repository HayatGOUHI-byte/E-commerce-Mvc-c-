﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DB_Context.Models /*folder*/
{
    
    public class CompanyContext : DbContext { 
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GGJC2K1;Initial Catalog=Employer;Integrated Security=True;");
            }
        }

      

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<Department>(entity =>
             {
                 entity.Property(e => e.Name)
                     .IsRequired()
                     .HasMaxLength(50)
                     .IsUnicode(false);
             });

             modelBuilder.Entity<Employee>(entity =>
             {
                 entity.Property(e => e.Designation)
                     .IsRequired()
                     .HasMaxLength(25)
                     .IsUnicode(false);

                 entity.Property(e => e.Name)
                     .IsRequired()
                     .HasMaxLength(100)
                     .IsUnicode(false);

                 entity.HasOne(d => d.Department)
                     .WithMany(p => p.Employee)
                     .HasForeignKey(d => d.DepartmentId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Employee_Department");
             });
         }*/
    }
}