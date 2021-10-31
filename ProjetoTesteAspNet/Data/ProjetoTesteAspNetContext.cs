using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoTesteAspNet.Models;

namespace ProjetoTesteAspNet.Data
{
    public class ProjetoTesteAspNetContext : DbContext
    {
        public ProjetoTesteAspNetContext (DbContextOptions<ProjetoTesteAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoTesteAspNet.Models.Department> Department { get; set; }
    }
}
