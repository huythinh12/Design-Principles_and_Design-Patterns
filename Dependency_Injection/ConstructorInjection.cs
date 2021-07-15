using System;


namespace ContructorInjection
{
  
    //-----------------------------------Example------------------------------------- 
    //-----------------------------------Problem------------------------------------- 
    /*  public class EmailService
      {
          public void sendMeassage(string message)
          {
              Console.WriteLine("Email message " + message);
          }
      }

      public class SmsService
      {
          public void sendMeassage(string message)
          {
              Console.WriteLine("Email message " + message);
          }
      }

      public class UserController
      {
          private EmailService emailService = new EmailService();
          private SmsService smsService = new SmsService();

          public void sendEmail()
          {
              emailService.sendMeassage("UserController");
          }

          public void sendSms()
          {
              smsService.sendMeassage("UserController");

          }
      }
    */
    //-----------------------------------Solved-------------------------------------
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
    public class SmsService : MessageService
    {
        public void sendMessage(string message)
        {
            Console.WriteLine("SmsService message " + message);
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
