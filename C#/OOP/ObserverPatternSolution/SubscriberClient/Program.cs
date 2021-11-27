using PublisherLib.Publisher;
using SubscriberClient.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Shivam Sutar", 5000, 8291476177, "shivam@gmail.com");
            acc1.AddNotifier(new SMSNotifier());
            acc1.AddNotifier(new EmailNotifier());
            acc1.Deposit(1000);
        }
    }
}
