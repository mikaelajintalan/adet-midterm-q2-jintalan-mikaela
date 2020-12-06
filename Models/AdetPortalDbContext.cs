using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace adet_midterm_q2_jintalan_mikaela.Models
{
    public class AdetPortalDbContext : DbContext
    {
        public AdetPortalDbContext(DbContextOptions<AdetPortalDbContext> options) : base(options)
        {
        }
        public DbSet<AdetPortal> StudentPortal { get; set; }
    }
}
