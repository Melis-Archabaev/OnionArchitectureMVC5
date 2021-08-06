using OnionApp.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.App.Infrasutructure.Data.Context
{
    public class OrderContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
