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
            if (!_mapBlocks.ContainsKey(mapBlockType))
            {
                switch(mapBlockType)
                {
                    case 'A':
                        _mapBlocks[mapBlockType] = new LandBlock();
                        break;
                    case 'B':
                        _mapBlocks[mapBlockType] = new SandBlock();
                        break;
                    case 'C':
                        _mapBlocks[mapBlockType] = new WaterBlock();
                        break;
                    default:
                        throw new ArgumentException("Invalid block type.");
                }
            }

            return _mapBlocks[mapBlockType];
        }
    }
}