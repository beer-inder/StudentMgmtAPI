using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMgmtAPI.Models;

namespace StudentMgmtAPI.Data
{
    public class StudentMgmtAPIContext : DbContext
    {
        public StudentMgmtAPIContext (DbContextOptions<StudentMgmtAPIContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMgmtAPI.Models.Student> Student { get; set; }
    }
}
