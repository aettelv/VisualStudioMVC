﻿
using Lab11.Models;
using System.Data.Entity;

namespace Lab11.DataAccessLayer
{
    public class SalesERPDAL: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
    }
}