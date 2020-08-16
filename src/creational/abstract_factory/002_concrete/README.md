# The Concrete Example

**The Concrete Example** makes use of the **abstract factory design pattern** to demonstrate how an **abstract factory**
can be used to interact with multiple related products, namely **Attack Items**, **Defense Items** and **Players**,
abstracting its creation processes from the client in a **HeavyGameFactory** and in a **LightGameFatory**, providing two
possible game setups. In this example, the abstract factory creates the multiple parts by invoking their constructors,
but an alternative implementation could rather invoke factories for each of these items in order to achieve the same
goal. In addition to that...

- **HeavyGameFactory** is responsible for creating related **HeavyAttackItem**, **HeavyDefenseItem** and **HeavyPlayer**
- **LightGameFactory** is responsible for creating related **LightAttackItem**, **LightDefenseItem** and **LightPlayer**
