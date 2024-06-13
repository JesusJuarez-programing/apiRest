using api_Humanos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_Humanos.Context
{
    public class contextview : DbContext
    {
        public DbSet<OperacionesInput> OperacionesInput { get; set; }

        
    }
}
