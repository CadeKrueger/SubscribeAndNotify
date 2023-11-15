# LikeAndSubscribe

In this mini-project, you will be making a very small system using c#. I think it's good to get used to different languages, and C# is the closest language there is to Java (as it was originally built as a Java clone, almost named J# before they were threatened with legal action).

In this project, I want to have you try your hand at this system before I explain a new, helpful design pattern for us to use. In any case, here's the project.

## Subscriber Model
In this project, you will be tasked with implementing methods in a Channel and Subscriber class. The basic goal of the project is to be able to have Subscribers be notified whenever a channel publishes a new Video. Then, it should keep track of the new videos it is notified about in a List called List<Notification> notificationList.

Then when PrintNotificationCount is called, it will print out a string with the number of notifications that user has pending.
And when PrintNotifications is called, it will print out each notification, then clear the list of notifications.

When a Channel calls channel.PublishVideo("[VIDEO TITLE]"), each subscriber that is subscribed to that channel should receive a notification.

The output for the final code should look like this

> Tom you have 3 notifications.

> Jerry you have 3 notifications.

> Sebastian you have 1 notifications.

> Tom you have 6 notifications.

> Jerry you have 4 notifications.

> Sebastian you have 3 notifications.

> Hey Tom, Cool News just published a new video called Breaking: Man Shatters Esophagus

> Hey Tom, Cool News just published a new video called Breaking: Girl Bakes Cookies

> Hey Tom, BANDIT just published a new video called House Haul: Jefferson Park

> Hey Tom, Cool News just published a new video called Breaking: GamerNews under Fire

> Hey Tom, Gamer Brigade just published a new video called Apology

> Hey Tom, BANDIT just published a new video called How I Got Away with Stealing from GamerNews

> Hey Jerry, Cool News just published a new video called Breaking: Man Shatters Esophagus

> Hey Jerry, Cool News just published a new video called Breaking: Girl Bakes Cookies

> Hey Jerry, Gamer Brigade just published a new video called Top 10 Anime Betrayals

> Hey Jerry, Gamer Brigade just published a new video called Apology

> Hey Jerry, Gamer Brigade just published a new video called Going Forward
