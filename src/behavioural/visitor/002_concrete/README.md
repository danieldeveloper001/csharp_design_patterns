# The Upgradable and Downgradable Game Items

**The Upgradable and Downgradable Game Items** makes use of the **visitor design pattern** for providing additional
functionality to game item objects in order to provide **upgrade**, **downgrade** and **display** features, without the
need for changing their existing implementations. In order to achieve such goal, each visitor knows about the existing
game items and provides the implementation logic for perfoming the specific operation implemented by it.