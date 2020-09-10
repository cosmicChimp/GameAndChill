using GameAndChillAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 3RD STEP, USED FOR CONNECTING MODELS TO DATABASE

namespace GameAndChillAPI.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // SETS MIGRATION PATH FOR DATABASE, POPULATES DATABASE WITH MODEL NAME
        public DbSet<Value> Values { get; set; }
        //   FROM MODEL^    ^ POPULATES DB WITH THIS NAME

    }
}
