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
    public class Warehouse
    {
       
        public long ID { get; set; }
        public DateTime Shelf_life { get; set; }
        public string Name_Ingredient { get; set; }
        public string Incept_date { get; set; }
        public int Volume { get; set; }
        public string Producer { get; set; }
        public int Cost { get; set; }
    }
}
