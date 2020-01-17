using System;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage {
                Subject = "Test Message",
                Body = "Hi, This is a Test Message"
            };

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            UserMessage userMessage = new UserMessage{
                Subject = "Test Message",
                Body = "Hi, This is a Test Message",
                UserComments = "I hope you are well"
            };

            userMessage.MessageSender = email;
            userMessage.Send();

            Console.ReadKey();
        }
    }

    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email\n{subject}\n{body}\n");
        }
    }

    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"MSMQ\n{subject}\n{body}\n");
        }
    }

    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Web Service\n{subject}\n{body}\n");
        }
    }

    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public abstract void Send();
    }

    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }

    public class UserMessage : Message
    {
        public string UserComments { get; set; }
        public override void Send()
        {
            string fullBody = $"{Body}\nUser Comments: {UserComments}";
            MessageSender.SendMessage(Subject, fullBody);
        }
    }
}
