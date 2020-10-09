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
    public class Employee
    {
        
        public long ID { get; set; }
        public string FGS { get; set; }
        public int Old { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Telefon { get; set; }
        public string Pasport { get; set; }
        public  DbSet<Position> ID_Positions { get; set; }
        


    }
}
