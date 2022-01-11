using Microsoft.EntityFrameworkCore;
using PlagiarismChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiarismChecker.Data
{
    class PlagiarismContext : DbContext
    {
        public PlagiarismContext(DbContextOptions<PlagiarismContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<ComparisonHistory> ComparisonHistories { get; set; }
    }
}
