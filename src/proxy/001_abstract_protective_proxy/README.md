# The Abstract Protective Proxy Example

**The Abstract Protective Proxy Example** makes use of the **proxy design pattern** to demonstrate how to control access
to a service while preserving contract compatibility for the **client**, by implementing authorization logic on the
**proxy service** that will be validated prior to invoking the **real service** and making both of them implement the
same public contract.