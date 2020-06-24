# The Promotable and Demotable Adventurer

**The Promotable and Demotable Adventurer** example makes use of the **state design pattern** to allow a **player**
behaviour to change based on its current **player class**, by delegating part of the **attack** an **defend** logic to
the **player class** respecting state specific rules of these actions, as stated below.

- **Low Rank**
  - Players within this class has **10 attack points** and **5 defense points** and can be promoted when the
    experience reaches 50 points or more.
  - No demotion is possible, since this is the lowest rank possible.
- **Mid Rank**
  - Players within this class has **20 attack points** and **10 defense points** and can be promoted when the
    experience reaches 100 points or more or demoted when the experience reaches 50 points or less.
- **High Rank**.
  - Players within this class has **30 attack points** and **15 defense points** and can be demoted when the
    experience reaches 100 points or less.
  - No promotion is possible, since this is the highest rank possible.
