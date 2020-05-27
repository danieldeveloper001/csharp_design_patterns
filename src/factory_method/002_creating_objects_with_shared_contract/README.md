# The Space Shooter Power Ups

**The Space Shooter Power Ups** makes use of the **factory method design pattern** for creating instances of different
types of randomly spawn powerups through factories that handle the creation process, each one with its specific set of
rules, so that neither the game engine nor the player are tied with the implementation details from the power ups
themselves. In this example, the **IPowerUpFactory** interface stabilishes a contract for **IPowerUp** creation, through
the factory method **Create**, which is then implemented by classes that implement this contract is such a way that...

- **LifePowerUpFactory** handles **LifePowerUp** creation logic and creation rules;
- **ShieldPowerUpFactory** handles **ShieldPowerUp** creation logic and creation rules;
- **SpeedPowerUpFactory** handles **SpeedPowerUp** creation logic and creation rules;
- **WeaponPowerUpFactory** handles **WeaponPowerUp** creation logic and creation rules;

... that in turn can be applied to an **IShip** by the powerup **ApplyTo** method, respecting the stabilished rules for
its actions.
