using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;

namespace SubscriberClient.Subscriber
{
    class EmailNotifier : INotifier
    {
        public void Notify(Account ac1)
        {
            Console.WriteLine("Email sent to : {0} {1} {2} {3} {4}", ac1.AcNo, ac1.Name, ac1.Balance, ac1.Mobile, ac1.Email);
        }
    }
}
