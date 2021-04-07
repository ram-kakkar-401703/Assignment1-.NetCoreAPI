using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment_Student_2.Models;

namespace Assignment_Student_2.Data
{
    public class Assignment_Student_2Context : DbContext
    {
        public Assignment_Student_2Context (DbContextOptions<Assignment_Student_2Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment_Student_2.Models.Student> Student { get; set; }
    }
}
