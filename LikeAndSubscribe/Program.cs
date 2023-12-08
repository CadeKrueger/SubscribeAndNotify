
using LikeAndSubscribe;
using System.Net;

public class Program
{
    public static void Main2()
    {
        Subscriber subTom = new Subscriber("Tom");
        Subscriber subJer = new Subscriber("Jerry");
        Subscriber subSeb = new Subscriber("Sebastian");

        Channel chNews = new Channel("Cool News");
        Channel chThief = new Channel("BANDIT");
        Channel chGamer = new Channel("Gamer Brigade");


        subTom.SubscribeTo(chNews);
        subTom.SubscribeTo(chThief);

        subJer.SubscribeTo(chGamer);
        subJer.SubscribeTo(chNews);

        subSeb.SubscribeTo(chThief);

        chNews.PublishVideo("Breaking: Man Shatters Esophagus");
        chNews.PublishVideo("Breaking: Girl Bakes Cookies");
        chGamer.PublishVideo("Top 10 Anime Betrayals");
        chThief.PublishVideo("House Haul: Jefferson Park");

        subTom.PrintNotificationCount(); // 3
        subJer.PrintNotificationCount(); // 3
        subSeb.PrintNotificationCount(); // 1


        subTom.SubscribeTo(chGamer);
        subSeb.SubscribeTo(chNews);
        subJer.UnsubscribeFrom(chNews);

        chNews.PublishVideo("Breaking: GamerNews under Fire");
        chGamer.PublishVideo("Apology");
        chThief.PublishVideo("How I Got Away with Stealing from GamerNews");

        subTom.PrintNotificationCount(); // 6
        subJer.PrintNotificationCount(); // 4
        subSeb.PrintNotificationCount(); // 3

        subTom.UnsubscribeFrom(chGamer);

        chGamer.PublishVideo("Going Forward");


        /*
         *  Hey Tom, Cool News just published a new video called Breaking: Man Shatters Esophagus
         *  Hey Tom, Cool News just published a new video called Breaking: Girl Bakes Cookies
         *  Hey Tom, BANDIT just published a new video called House Haul: Jefferson Park
         *  Hey Tom, Cool News just published a new video called Breaking: GamerNews under Fire
         *  Hey Tom, Gamer Brigade just published a new video called Apology
         *  Hey Tom, BANDIT just published a new video called How I Got Away with Stealing from GamerNews
        */
        subTom.PrintNotifications();

        /*
         *  Hey Jerry, Cool News just published a new video called Breaking: Man Shatters Esophagus
         *  Hey Jerry, Cool News just published a new video called Breaking: Girl Bakes Cookies
         *  Hey Jerry, Gamer Brigade just published a new video called Top 10 Anime Betrayals
         *  Hey Jerry, Gamer Brigade just published a new video called Apology
         *  Hey Jerry, Gamer Brigade just published a new video called Going Forward
        */
        subJer.PrintNotifications();
    }

    /*
     * HINT AND HELPFUL SHORTCUTS:
     *     String.Format("Hey {0}, {1} just published a new video called {2}", [SUBSCRIBER NAME], [CHANNEL NAME], [VIDEO TITLE]);
     */
}