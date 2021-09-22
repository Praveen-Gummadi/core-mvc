using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace core_mvc.Models
{
    public class connectionStringClass : DbContext
    {
        public connectionStringClass(DbContextOptions<connectionStringClass> options) : base(options)
        {

        }
        public DbSet<EmpClass> emp { set; get; }
        
    } 
}
