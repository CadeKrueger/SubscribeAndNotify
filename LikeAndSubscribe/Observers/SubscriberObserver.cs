using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeAndSubscribe
{
    public class SubscriberObserver : Observer
    {
        public SubscriberObserver() { }

        public override void DecideToNotify(Subscriber sub, Notification notification, VIDEO_TYPE video_type)
        {
            switch (video_type)
            {
                case VIDEO_TYPE.Standard:
                    if (sub.GetNotificationCount() < 3) sub.AddNotification(notification);
                    break;
                case VIDEO_TYPE.NotifyAll: 
                    sub.AddNotification(notification);
                    break;
            }
        }
    }
}
