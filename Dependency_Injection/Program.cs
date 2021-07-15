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
            Console.WriteLine("-----------------Constructor Injection----------------");
            Console.WriteLine("Example 1:");
            var dbMigrator1 = new DbMigrator(new Logger());
            var installer1 = new Installer(new Logger());
            //excute method
            dbMigrator1.Migrate();
            installer1.Install();

            Console.WriteLine("Example 2:");
            EmailService messageService = new EmailService();
            UserController userController = new UserController(messageService);
            //excute method
            userController.send();
            Console.ReadKey();
        }
    }
}
