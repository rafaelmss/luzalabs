using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Luisalabs_Employee_Manager.DAL
{
    public class LuizalabsContext : DbContext
    {
        public LuizalabsContext() : base("LuizalabsContext")
        {
        }

        public DbSet<Models.Employee> Employees { get; set; }
    }
}