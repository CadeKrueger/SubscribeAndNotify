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
            channel.UpdateSubscriberStatus(this, VIEWER_TYPE.NORMAL);
        }

        public void UnsubscribeFrom(Channel channel)
        {
            channel.UpdateSubscriberStatus(this, VIEWER_TYPE.BLOCKED);
        }

        public void AddNotification(Notification notification)
        {
            this.notificationList.Add(notification);
        }

        public void Like(Channel channel)
        {
            channel.UpdateSubscriberStatus(this, VIEWER_TYPE.LIKED);
        }

        public void Block(Channel channel)
        {
            channel.UpdateSubscriberStatus(this, VIEWER_TYPE.BLOCKED);
        }

        public void RingThatBell(Channel channel)
        {
            channel.UpdateSubscriberStatus(this, VIEWER_TYPE.BELL);
        }

        public void UnringThatBell(Channel channel)
        {
            channel.UpdateSubscriberStatus(this, VIEWER_TYPE.NORMAL);
        }


        public int GetNotificationCount() { return notificationList.Count(); }

        public void PrintNotificationCount()
        {
            Console.WriteLine("{0} you have {1} notification(s).", subscriberName, GetNotificationCount());
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
