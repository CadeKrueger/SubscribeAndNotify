using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeAndSubscribe
{
    public class BellObserver : Observer
    {
        public BellObserver() { }

        public override void DecideToNotify(Subscriber sub, Notification notification, VIDEO_TYPE video_type)
        {
            if (video_type == VIDEO_TYPE.Standard || video_type == VIDEO_TYPE.NotifyAll)
            {
                sub.AddNotification(notification);
            }
        }

    }
}
