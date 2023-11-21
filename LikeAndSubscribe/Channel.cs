using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LikeAndSubscribe
{
    public class Channel
    {
        public String channelName;
        private List<Subscriber> subscribers = new List<Subscriber>();
        public Channel(String name) {
            this.channelName = name;
        }
        public void PublishVideo(String name)
        {
            foreach (Subscriber subscriber in subscribers)
            {
                String notificationText = String.Format("Hey {0}, {1} just published a new video called {2}", subscriber.subscriberName, this.channelName, name);
                Notification notification = new Notification(notificationText);
                subscriber.AddNotification(notification);
            }
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(Subscriber subscriber)
        {
            this.subscribers.Remove(subscriber);
        }

    }
}
