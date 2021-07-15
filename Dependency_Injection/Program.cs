using System;

using ContructorInjection;

namespace Dependency_Injection
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Constructor Injection----------------");
            //EmailService messageEmail = new EmailService();
            //SmsService messageSms = new SmsService();
            MessageService messageEmail = new EmailService();
            MessageService messageSms = new SmsService();

            UserController userSendEmail = new UserController(messageEmail);
            UserController userSendSms = new UserController(messageSms);

            //execute method
            userSendEmail.send();

            userSendSms.send();

            Console.ReadKey();
        }
    }
}
