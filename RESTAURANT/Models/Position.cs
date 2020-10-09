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
    public class Position
    {
       
        public long ID { get; set; }
        public string Name_Positions { get; set; }
        public int Salary { get; set; }
        public string Responsibilities { get; set; }
        public string Requirements { get; set; }

    }
}
