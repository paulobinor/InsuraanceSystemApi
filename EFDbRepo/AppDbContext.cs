using EHR.Api.Dtos;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFDbRepo
{
    public class AppDbContext: DbContext
    {

        public DbSet<PolicyHolder> PolicyHolders { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=InsuranceSysDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}