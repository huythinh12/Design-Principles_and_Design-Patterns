using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ContructorInjection;

namespace Dependency_Injection
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator1 = new DbMigrator(new Logger());
            var installer1 = new Installer(new Logger());
            //excute method
            dbMigrator1.Migrate();
            installer1.Install();

            Console.ReadKey();
        }
    }
}
