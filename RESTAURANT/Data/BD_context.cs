using RESTAURANT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAURANT.Data
{
    public class BD_context : DbContext
    {
        public  DbSet<Warehouse> ID_Ingredient_1 { get; set; }
   
        public  DbSet<Menu> ID_dish_1 { get; set; }
    
        public  DbSet<Position> ID_Positions { get; set; }
        public DbSet<Order> ID_employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>((o =>
            {
                o.HasNoKey();
            }));
        }
        //сщььше
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
        {
            optionsBuilder.UseSqlServer("Data Source=(localbd)\\MSSQLLlocalDB; Initial Catalog=REST");
        }
         
    }
}
