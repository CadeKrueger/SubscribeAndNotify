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

## Part 2
In part 2 of the assignment, we will expand the functionality significantly of this program.

### Channel
For our channel class, we want to add a couple new features

#### VIDEO_TYPE

```c#
    enum VIDEO_TYPE
    {
        Standard,
        NotifyAll,
        NotifyNone,
        NonSubscribers
    }
```

We want to create this enum which will specify who we want to notify when a new video is released.

In general:
- **Standard**. Notify all Subscribers with less than 3 notifications queued. If they are a Bell Subscriber, notify them always. Finally, if they have liked the channel, but aren't otherwise subscribed, send them the notification 33% of the time.
- **NotifyAll**. Notify all Subscribers.
- **NotifyNone**. Notify no one about new video.
- **NonSubscribers**. Send the video to people who have liked the channel, but haven't subscribed.

Now when we call publish video, we want an optional parameter called VIDEO_TYPE type, which will specify the notification behavior we want.

### Subscriber

Additionally, we want to add some new functionality to the Subscriber class. Our subscriber should have functions for the following actions:

#### Like(Channel channel)

In this function, we can like a channel without subscribing to it. We will get notified about 33% of videos published by this channel. See VIDEO_TYPE rules above.

#### Block(Channel channel)

In this function, we want to unsubscribe from having liked the channel, and receive no future notifications about this channel.

#### RingThatBell(Channel channel) 

In this function, we want to receive as many notifications from the channel as possible. See VIDEO_TYPE rules above.

#### UnringThatBell(Channel channel)

In this function, we want to go back to only receiving normal notifications. See VIDEO_TYPE rules above.

### Final Notes
One final rule. Attempt to do this without bloating the Channel class. Consider a SubscriptionBot class. The Channel class should have no more than 3-4 methods (+1 for its constructor)
