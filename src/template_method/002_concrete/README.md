# The Fighters Game Example

**The Fighters Game Example** makes use of the **template method design pattern** to demonstrate how to share **attack**
and **deffend** common implementation between **assassin** and **ninja** player classes, while being able to customize
specific behaviours by extracting part of the logic to abstract methods on the **player abstract class**, which will be
implemented by any **player concrete class**. In the example, some of the custom behaviours include:

- Assassin
  - Maximum attack power is 5
  - Maximum defense power is 3
  - Attack is stronger when life is high (the liveliness sharpens his senses).
  - Defense has its full power activated by strong attacks.
  - Assassin specific acting cool attack messages.
- Ninja
  - Maximum attack power is 3
  - Maximum defense power is 5
  - Attack is stronger when life is low (the danger sharpens his senses).
  - Defense is not affected by strong attacks.
  - Ninja specific acting cool attack messages.
