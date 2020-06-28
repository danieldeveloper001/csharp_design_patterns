# The Abstract Virtual Proxy Example

**The Abstract Virtual Proxy Example** makes use of the **proxy design pattern** to demonstrate how to make resources
locally available on **proxy service** after retrieved from the **real service** while preserving resource consumption,
by implementing on demand caching for previously read data, preventing the real service from reading the data file for
getting the same row multiple times and by making both of them implement the same public contract, preserving client
compatibility.