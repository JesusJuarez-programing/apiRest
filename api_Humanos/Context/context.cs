using api_Humanos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_Humanos.Context
{
    public class context: DbContext
    {
        public DbSet<Humanos> Humanos { get; set; }

        public context(DbContextOptions<context> options)
        : base(options)
        {
        }
    }
}
