using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmaZon.Models;

namespace Amazon.Data
{
    public class MvcPaisContext : DbContext
    {
        public MvcPaisContext (DbContextOptions<MvcPaisContext> options)
            : base(options)
        {
        }

        public DbSet<AmaZon.Models.Pais> Pais { get; set; } = default!;
    }
}
