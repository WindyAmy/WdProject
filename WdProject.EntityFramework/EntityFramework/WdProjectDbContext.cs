using System.Data.Common;
using Abp.EntityFramework;

namespace WdProject.EntityFramework
{
    public class WdProjectDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WdProjectDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WdProjectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WdProjectDbContext since ABP automatically handles it.
         */
        public WdProjectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WdProjectDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public WdProjectDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
