# The Abstract Remote Proxy Example

**The Abstract Remote Proxy Example** makes use of the **proxy design pattern** to demonstrate how to invoke remote
serive resources as if local resources while preserving contract compatibility for the **client**, by invoking the
**proxy service** which delegates the operation to the **remote service** and making both of them implement the
same public contract in order to achieve such goal.

Notice that this example just simulates a proxy service delegation to a remote service by putting them appart in
different namespaces. In real worls scenarios the remote service contract and implementation wouldn't be part of the
client application.