using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeAndSubscribe
{
    public class Channel
    {
        private String channelName;

        private List<Observer> observerList = new();

        public Channel(String name)
        {
            this.channelName = name;
            RegisterObserver(new SubscriberObserver());
            RegisterObserver(new BellObserver());
            RegisterObserver(new LikeObserver());
        }

        private void RegisterObserver(Observer observer) { this.observerList.Add(observer); }

        public void PublishVideo(String name) { PublishVideo(name, VIDEO_TYPE.Standard); }
        public void PublishVideo(String name, VIDEO_TYPE video_type)
        {
            foreach (Observer observer in observerList)
            {
                observer.Notify(this.channelName, name, video_type);
            }
        }

        public void UpdateSubscriberStatus(Subscriber subscriber, VIEWER_TYPE viewer_type)
        {
            foreach (Observer observer in observerList)
            {
                observer.Update(subscriber, (set, sub) => set.Remove(sub));
            }
            // No need for a BLOCKED observer since we treat them the same as non-subs
            #pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                this.observerList[(int)viewer_type].Update(subscriber, (set, sub) => set.Add(sub));
            }
            catch (Exception e) { }
            #pragma warning restore CS0168 // Variable is declared but never used
        }

    }
}
