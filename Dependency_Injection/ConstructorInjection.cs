using System;


namespace ContructorInjection
{
    //-----------------------------------Example 1------------------------------------- 
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
        private readonly Logger logger;
        public DbMigrator(Logger logger)
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            //viet ra thong bao trong qua trinh migrate 
            logger.Log("We are migrating blah blah blha...");
        }
    }
    public class Installer
    {
        //composition
        private readonly Logger logger;
        public Installer(Logger logger)
        {
            this.logger = logger;
        }
        public void Install()
        {
            //viet ra thong bao trong qua trinh install app
            logger.Log("We are installing the application");
        }
    }

    //-----------------------------------Example 2------------------------------------- 
    public interface MessageService
    {
        void sendMessage(string message);
    }
    public class EmailService : MessageService
    {
        public void sendMessage(string message)
        {
            Console.WriteLine("Email message " + message);
        }
    }
    public class UserController
    {
        private readonly MessageService messageService;
        public UserController(MessageService messageService)
        {
            this.messageService = messageService;
        }
        public void send()
        {
            messageService.sendMessage("User Controller");
        }
    }
}
