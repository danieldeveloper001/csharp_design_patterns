## The Media Burner Example

**The Media Burner Example** makes use of the **prototype design pattern** in order to create prebuild **prototypes**
for optical media types with predefined capacity information, which are managed in a **registry** that will be consumed
by an optical media type burner to determine the supported media types and selecting the correct one based on user
input, avoiding the need for subclassing for each supported media type, which is one of the possible uses for this
design pattern.
