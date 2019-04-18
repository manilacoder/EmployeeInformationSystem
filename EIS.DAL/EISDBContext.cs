using EIS.BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIS.DAL
{
    //inherit DBContext
    public class EISDBContext: DbContext
    {
        //Connection string name
        public EISDBContext():base("EISDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EISDBContext, EIS.DAL.Migrations.Configuration>());
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
