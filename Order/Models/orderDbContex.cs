using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Models
{
    public class orderDbContex : DbContext

    {
        public orderDbContex(DbContextOptions<orderDbContex> options) : base(options)
        {

        }
        public DbSet<order> orders{get;set;}
    }
}
