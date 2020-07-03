# The Abstract Example

**The Abstract Example** makes use of the **adapter design pattern** to demonstrate how make communication between a
client and a service provider with incompatible interfaces possible*. In this example, there is an utilitary class
**calculator** which can perform **sum** and **sub** operations with two numbers and a **client** that needs to perform
**sum** and **sub** operations with any given number of arguments. Such incompatibility is resolved by the
**multiparameter calculator adapter**, which encapsulates the **calculator** through its base class **calculator
adapter** and receives the desired parameters. The **calculator adapter** is not a requirement for the adaptation
process but, it makes the code more flexible if the client requirements change, so that other adapters could be created
without breaking the sum and sub operations performed by the client itself.

*Please, bear in mind that since this is a simple example, the **calculator** could have been modified in order to
accept any number of parameters rather than implementing an adapter to do such work but, in real world usage of this
design pattern, it would be already in use by multiple parts of the system and changes to its public contract would
break existing clients or it would be a class residing in a thirdy party library.