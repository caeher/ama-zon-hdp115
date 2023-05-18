using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace AmaZon.Data
{
    public class MVCPaisContext: DbContext
    {
        public MVCPaisContext (DbContextOptions<MVCPaisContext> options)
            : base(options)
        {
        }

        public DbSet<AmaZon.Models.DataPais> DataPais { get; set; }
    }
}