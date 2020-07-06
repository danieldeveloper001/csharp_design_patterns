# The Game Store

**The Game Store** makes use of the **iterator design pattern** for navigating through a collection of games in a
digital store with multiple search criteria strategies, while preserving both the collection and collection items
encapsulation and keeping the client decoupled from the underlying query and iteration logic.

- **SinglePlayerIterator**: filter the main collection and navigate through games that has both `HasLocalMultiplayer`
  and `HasRemoteMultiplayer` set to `false`.
- **LocalPlayerIterator**: filter the main collection and navigate through games that has `HasLocalMultiplayer` set to
  `true`
- **RemotePlayerIterator**: filter the main collection and navigate through games that has `HasRemoteMultiplayer` set to
  `true`