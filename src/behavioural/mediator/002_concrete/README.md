# The Flight Controller Example

**The Flight Controller Example** makes use of the **mediator design pattern** to demonstrate how the a **mediator**
class can handle communication between multiple **colleague** classes in a simple flight controller application. In
order to achieve such goal, the **sender plane** report its location to the **flight controller** that notifices every
**receiver plane** in order to retrieve their current distance and validate it with the **safe distance threshold**.
