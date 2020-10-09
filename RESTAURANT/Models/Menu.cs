using RESTAURANT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RESTAURANT.Models
{
    public class Menu
    {
       
        public long ID { get; set; }
        public int Volume_Ingredient_1 { get; set; }
        public DateTime Cooking_time { get; set; }
        public string Name_dish { get; set; }
        public int Volume_Ingredient_2 { get; set; }
        public int Volume_Ingredient_3 { get; set; }

        public int Cost { get; set; }
        public  DbSet<Warehouse> ID_Ingredient_1 { get; set; }
        public DbSet<Warehouse> ID_Ingredient_2 { get; set; }

        public  DbSet<Warehouse> ID_Ingredient_3 { get; set; }





    }
}
