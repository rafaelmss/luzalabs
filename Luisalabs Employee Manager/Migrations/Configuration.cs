namespace Luisalabs_Employee_Manager.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Luisalabs_Employee_Manager.DAL.LuizalabsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Luisalabs_Employee_Manager.DAL.LuizalabsContext context)
        {
            var employees = new List<Models.Employee>
            {
            new Models.Employee{Name="Rodrigo Carvalho",Email="rodrigo@luizalabs.com",Department="IntegraCommerce"},
            new Models.Employee{Name="Renato Pedigoni",Email="renato@luizalabs.com",Department="Digital Platform"},
            new Models.Employee{Name="Thiago Catoto",Email="catoto@luizalabs.com",Department="Mobile"}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}
