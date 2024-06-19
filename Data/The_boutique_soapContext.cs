using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using The_boutique_soap.Models;

namespace The_boutique_soap.Data
{
    public class The_boutique_soapContext : DbContext
    {
        public The_boutique_soapContext (DbContextOptions<The_boutique_soapContext> options)
            : base(options)
        {
        }

        public DbSet<The_boutique_soap.Models.Movie> Movie { get; set; } = default!;
    }
}
