# The Adventurer Game

**The Adventurer Game** makes use of the **observer design pattern** to send notifications to **achievement** instances
that relies on **player** instance state changes so that these instances are able to validate whether the achievement
has been achieved or not. During the notification process, three scenarios are possible for each achievement.

- if it was previously achieved for the first time, the state of the achievement isn't updated.
- if it was not achieved, the state of the achievement isn't updated.
- if it was achieved, the state of the achievement is updated.

Since each kind of achievement depends upon different conditions being met by the player, a common interface is
stabilished between them, so that all achievements can be uniformely processed and the player unaware of each
achievement logic implementation.
