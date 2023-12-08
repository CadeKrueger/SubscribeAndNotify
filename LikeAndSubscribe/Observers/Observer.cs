using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeAndSubscribe
{
    public abstract class Observer
    {
        private HashSet<Subscriber> members = new();

        public void Notify(string channelName, string videoName, VIDEO_TYPE video_type)
        {
            string notificationText = string.Format(", {0} just published a new video called {1}", channelName, videoName);
            foreach (Subscriber sub in members)
            {
                DecideToNotify(sub, new Notification("Hey " + sub.subscriberName + notificationText), video_type);
            }
        }

        public virtual void DecideToNotify(Subscriber sub, Notification notification, VIDEO_TYPE video_type)
        {
            sub.AddNotification(notification);
        }

        public void Update(Subscriber sub, Func<HashSet<Subscriber>, Subscriber, bool> func)
        {
            func(members, sub);
        }
    }
}
