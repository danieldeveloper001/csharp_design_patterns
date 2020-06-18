using System;
using System.Collections.Generic;

namespace Project
{
    public class MapBlockFactory
    {
        private Dictionary<char, IMapBlock> _mapBlocks;

        public MapBlockFactory()
        {
            _mapBlocks = new Dictionary<char, IMapBlock>();
        }

        public IMapBlock GetMapBlock(char mapBlockType)
        {
            if (_mapBlocks.ContainsKey(mapBlockType))
                return _mapBlocks[mapBlockType];

            switch(mapBlockType)
            {
                case 'A':
                    return _mapBlocks[mapBlockType] = new LandBlock();
                case 'B':
                    return _mapBlocks[mapBlockType] = new SandBlock();
                case 'C':
                    return _mapBlocks[mapBlockType] = new WaterBlock();
                default:
                    throw new ArgumentException("Invalid block type.");
            }
        }
    }
}