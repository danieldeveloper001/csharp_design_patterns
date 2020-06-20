# The Game Map

**The Game Map** example makes use of the **flyweight design pattern** for loading game maps from text files and mapping
them into a bidimensional matrix of map blocks, which are instantiated on demand and only once at a map block factory,
so that they can be reused. Map blocks have a description as intrinsic state which is immutable and varies based on the
block type and can be drawn on the screen by receiving extrinsic state which is mutable and varies based on the block
location at the map.
