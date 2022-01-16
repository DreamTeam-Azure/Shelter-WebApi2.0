using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shelter_Azure_2.Models;

namespace Shelter_Azure_2.Data
{
    public class ShelterDbContext : DbContext
    {
        public ShelterDbContext() { }
        public ShelterDbContext(DbContextOptions<ShelterDbContext> options)
            : base(options)
        { }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
