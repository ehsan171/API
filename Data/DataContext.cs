using System.IO.Pipelines;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options) {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection_2"));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BarnameGroup>().HasKey(sc => new { sc.BarnameId, sc.BasicDataId });
            modelBuilder.Entity<BarnameNetwork>().HasKey(sc => new { sc.BarnameId, sc.BasicDataId });
            modelBuilder.Entity<BarnameProducer>().HasKey(sc => new { sc.BarnameId, sc.PersonId });
            modelBuilder.Entity<Allocation>().HasKey(sc => new { sc.Id });
            


            base.OnModelCreating(modelBuilder);
        }



        public DbSet<User> Users { get; set; }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<BasicData> BasicDatas { get; set; }

        public DbSet<ProcessDataReg> ProcessDataRegs { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Barname> Barname { get; set; }

        public DbSet<BarnameGroup> BarnameGroups { get; set; }

        public DbSet<BarnameNetwork> BarnameNetworks { get; set; }

        public DbSet<BarnameProducer> BarnameProducers { get; set; }

        public DbSet<Allocation> Allocations { get; set; }

         public DbSet<TimeSection> TimeSections { get; set; }

        
        
        
    }


}