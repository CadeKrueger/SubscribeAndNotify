using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeAndSubscribe
{
    public class LikeObserver : Observer
    {
    public LikeObserver() { }

    public override void DecideToNotify(Subscriber sub, Notification notification, VIDEO_TYPE video_type)
    {
        switch (video_type)
        {
            case VIDEO_TYPE.Standard:
                if (new Random().NextDouble() <= (1.0 / 3.0)) { sub.AddNotification(notification); };
                break;
            case VIDEO_TYPE.NonSubscribers: 
                sub.AddNotification(notification);
                break;
        }
    }

}
}
