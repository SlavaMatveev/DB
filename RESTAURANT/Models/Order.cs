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
    public class Order
    { 
        
        public DateTime Time { get; set; }
        public DateTime Date { get; set; }
        public string check {get;set;}
        public int Cost { get; set; }
        public string FGS_employer { get; set; }
        public int Telefon { get; set; }
        public DbSet<Menu> ID_dish_1 { get; set; }
        public  DbSet<Menu> ID_dish_2 { get; set; }
        public  DbSet<Menu> ID_dish_3 { get; set; }
        public DbSet<Employee> ID_employees { get; set; }

    }
}
