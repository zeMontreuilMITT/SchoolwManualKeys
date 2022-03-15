#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolwManualKeys.Models;

namespace SchoolwManualKeys.Data
{
    public class SchoolwManualKeysContext : DbContext
    {
        public SchoolwManualKeysContext (DbContextOptions<SchoolwManualKeysContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolwManualKeys.Models.Course> Course { get; set; }
    }
}
