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
        public DbSet<Board> Boards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5O7RUKC\SQLEXPRESS;Database=Property;User Id=sa;Password =sa1234; ");
        }
    }
}
