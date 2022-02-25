using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL3.Models;
using Microsoft.EntityFrameworkCore;

namespace MobileBackend
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Monster> Monster { get; set; }

    }
}
