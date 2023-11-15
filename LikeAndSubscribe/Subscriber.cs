using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LikeAndSubscribe
{
    
    public class Subscriber
    {
        public String subscriberName;
        private List<Notification> notificationList = new List<Notification>();

        public Subscriber(String name)
        {
            subscriberName = name;
        }

        public void SubscribeTo(Channel channel)
        {

        }

        public void UnsubscribeFrom(Channel channel) {
            
        }

        public void PrintNotificationCount()
        {
            Console.WriteLine(String.Format("{0} you have {1} notifications.", subscriberName, notificationList.Count()));
        }

        public void PrintNotifications()
        {
            foreach(Notification notification in notificationList)
            {
                Console.WriteLine(notification.notificationText);
            }
            notificationList.Clear();
        }
    }
}
