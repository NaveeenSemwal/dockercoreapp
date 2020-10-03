using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerAPI
{
    public class DockerDbContext : DbContext
    {
        public DockerDbContext(DbContextOptions<DockerDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Summary> Summaries { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Summary>().HasData(new Summary
        //    { Id = 1, Name = "Freezing" }, new Summary { Id = 2, Name = "Bracing" });

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
