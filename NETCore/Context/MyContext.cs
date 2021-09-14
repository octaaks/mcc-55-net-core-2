using Microsoft.EntityFrameworkCore;
using NETCore.Models;
using NETCore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Account> Accounts{ get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Profiling> Profilings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<PersonVM> PersonVMs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Person --- Acount
            modelBuilder.Entity<Person>()
                .HasOne(a => a.Account)
                .WithOne(p => p.Person)
                .HasForeignKey<Account>(a => a.NIK);

            //Account --- Profiling
            modelBuilder.Entity<Account>()
                .HasOne(pr => pr.Profiling)
                .WithOne(a => a.Account)
                .HasForeignKey<Profiling>(pr => pr.NIK);

            //Education --< Profilings
            modelBuilder.Entity<Education>()
                .HasMany(pr => pr.Profilings)
                .WithOne(e => e.Educations);

            //University --< Education
            modelBuilder.Entity<University>()
                .HasMany(e => e.Educations)
                .WithOne(u => u.Universities);

            //Account >---< Role
            modelBuilder.Entity<AccountRole>()
               .HasKey(ar => new { ar.AccountId, ar.RoleId });
            modelBuilder.Entity<AccountRole>()
                .HasOne(ar => ar.Account)
                .WithMany(a => a.AccountRoles)
                .HasForeignKey(ar => ar.AccountId);
            modelBuilder.Entity<AccountRole>()
                .HasOne(ar => ar.Role)
                .WithMany(r => r.AccountRoles)
                .HasForeignKey(ar => ar.RoleId);
        }
    }
}