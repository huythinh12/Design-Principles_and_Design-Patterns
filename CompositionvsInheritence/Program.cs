using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionvsInheritence
{
    namespace Composition
    {
        public class Logger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
        public class DbMigrator
        {
            //composition
            private Logger logger;
            public void Migrate()
            {
                logger = new Logger();
                //viet ra thong bao trong qua trinh migrate 
                logger.Log("We are migrating blah blah blha...");
            }
        }
        public class Installer
        {
            //composition
            private Logger logger;

            public void Install()
            {
                logger = new Logger();
                //viet ra thong bao trong qua trinh install app
                logger.Log("We are installing the application");
            }
        }
    }
    namespace Inheritence
    {
        public class Logger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
        public class DbMigrator : Logger
        {
            public void Migrate()
            {
                //viet ra thong bao trong qua trinh migrate 
                Log("We are migrating blah blah blha...");
            }
        }
        public class Installer : Logger
        {
            public void Install()
            {
                //viet ra thong bao trong qua trinh install app
                Log("We are installing the application");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Composition 
            Console.WriteLine("------------------Composition-----------------------");
            var dbMigrator1 = new Composition.DbMigrator();
            var installer1 = new Composition.Installer();
            //excute method
            dbMigrator1.Migrate();
            installer1.Install();

            //Inheritence 
            Console.WriteLine("------------------Inheritence-----------------------");
            var dbMigrator2 = new Inheritence.DbMigrator();
            var installer2 = new Inheritence.Installer();
            //excute method
            dbMigrator2.Migrate();
            installer2.Install();

            Console.ReadLine();
        }
    }
}
