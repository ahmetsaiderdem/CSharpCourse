using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo1
{
    public class ETradeContext:DbContext
    {
        public DbSet<Product> Type { get; set; }
    }
}
