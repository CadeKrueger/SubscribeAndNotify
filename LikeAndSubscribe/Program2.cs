
using LikeAndSubscribe;
using System.Net;

public class Program2
{
    public static void Main()
    {
        Subscriber subTom = new Subscriber("Tom");
        Subscriber subJer = new Subscriber("Jerry");
        Subscriber subSeb = new Subscriber("Sebastian");
        Subscriber subLou = new Subscriber("Lou");

        Channel chNews = new Channel("Cool News");
        Channel chThief = new Channel("BANDIT");
        Channel chGamer = new Channel("Gamer Brigade");
        Channel chFunny = new Channel("Laugh City");

        subTom.Like(chNews);
        subTom.SubscribeTo(chThief);
        subTom.Block(chFunny);

        subJer.SubscribeTo(chGamer);
        subJer.RingThatBell(chNews);

        subSeb.RingThatBell(chThief);
        subSeb.Like(chFunny);

        subLou.SubscribeTo(chNews);
        subLou.RingThatBell(chNews);
        subLou.Like(chThief);
        subLou.SubscribeTo(chGamer);
        subLou.Like(chFunny);

        chNews.PublishVideo("Breaking: Man Shatters Esophagus");
        chNews.PublishVideo("Breaking: Girl Bakes Cookies", VIDEO_TYPE.NotifyAll);
        chGamer.PublishVideo("Top 10 Anime Betrayals");
        chThief.PublishVideo("House Haul: Jefferson Park", VIDEO_TYPE.NotifyNone);
        chFunny.PublishVideo("Karens Getting Instant Karma", VIDEO_TYPE.NonSubscribers);


        subTom.PrintNotificationCount(); // 0 or 1
        subJer.PrintNotificationCount(); // 3
        subSeb.PrintNotificationCount(); // 1
        subLou.PrintNotificationCount(); // 4


        subTom.SubscribeTo(chNews);
        subTom.Like(chFunny);

        subJer.UnringThatBell(chNews);

        subSeb.Block(chThief);

        subLou.UnringThatBell(chNews);
        subLou.RingThatBell(chGamer);

        chNews.PublishVideo("Breaking: GamerNews under Fire");
        chGamer.PublishVideo("Apology");
        chThief.PublishVideo("How I Got Away with Stealing from GamerNews", VIDEO_TYPE.NonSubscribers);
        chFunny.PublishVideo("Drunk Fails", VIDEO_TYPE.NotifyAll);


        subTom.PrintNotificationCount(); // 1 or 2
        subJer.PrintNotificationCount(); // 3
        subSeb.PrintNotificationCount(); // 1
        subLou.PrintNotificationCount(); // 6


        /*
        (Possibly)----
        Hey Tom, Cool News just published a new video called Breaking: Man Shatters Esophagus
        --------------
        Hey Tom, Cool News just published a new video called Breaking: GamerNews under Fire
        */
        subTom.PrintNotifications();

        /*
        Hey Jerry, Cool News just published a new video called Breaking: Man Shatters Esophagus
        Hey Jerry, Cool News just published a new video called Breaking: Girl Bakes Cookies
        Hey Jerry, Gamer Brigade just published a new video called Top 10 Anime Betrayals
        */
        subJer.PrintNotifications();

        /*
        Hey Sebastian, Laugh City just published a new video called Karens Getting Instant Karma
        */
        subSeb.PrintNotifications();

        /*
        Hey Lou, Cool News just published a new video called Breaking: Man Shatters Esophagus
        Hey Lou, Cool News just published a new video called Breaking: Girl Bakes Cookies
        Hey Lou, Gamer Brigade just published a new video called Top 10 Anime Betrayals
        Hey Lou, Laugh City just published a new video called Karens Getting Instant Karma
        Hey Lou, Gamer Brigade just published a new video called Apology
        Hey Lou, BANDIT just published a new video called How I Got Away with Stealing from GamerNews
        */
        subLou.PrintNotifications();

    }

}