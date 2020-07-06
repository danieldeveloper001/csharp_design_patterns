# The Facade Restaurant

**The Facade Restaurant** example makes use of the **facade design pattern** for simplifying functionality consumption
by aggregating logic and method calls in methods with proper semantics that would otherwise be exposed to a client. In
this example, the **Restaurant** acts as a **facade** to the **Program** client, by providing ready to use
functionallity through the **Serve** method, that handles the inner working of the restaurant, such as...

- Selecting a random cook (or in more complex cases an available one) to prepare the meal.
- Selecting a random waiter (or in more complex cases an available one) to serve the customer.
- Taking an order from the customer;
- Sending the order to the cook;
- Preparing the orders;
- Delivering the orders;

...so that the client is responsible only for providing a few building blocks that makes the restaurant useful, such
as...

- One or more cook instances;
- One or more waiter instances;
- One or more customer instances;

...and then making customers happy.