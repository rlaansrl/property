using Microsoft.EntityFrameworkCore;
using Property.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property.DataContext
{
    public class PropertyDbContext :DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=119.192.49.164;Database=Property;User Id=sa;Password =qwer10; ");
        }
    }
}
