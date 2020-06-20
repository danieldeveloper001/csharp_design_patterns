using System;
using System.Linq;
using System.IO;

namespace Project
{
    public class Map
    {
        private MapBlockFactory _mapBlockFactory;
        private IMapBlock[,] _map;

        public Map(MapBlockFactory mapBlockFactory)
        {
            _mapBlockFactory = mapBlockFactory;

            _map = new IMapBlock[Settings.GAME_COLUMNS, Settings.GAME_ROWS];
            using (var reader = new StreamReader(Settings.MAP_PATH))
            {
                for(int row = 0; row < Settings.GAME_ROWS; row++)
                {
                    for (int column = 0; column < Settings.GAME_COLUMNS; column++)
                    {
                        var block = (char)reader.Read();
                        _map[column, row] = _mapBlockFactory.GetMapBlock(block);
                    }
                    reader.Read();
                }
            }
        }

        public void Draw()
        {
            for (int column = 0; column < Settings.GAME_COLUMNS; column++)
            {
                for(int row = 0; row < Settings.GAME_ROWS; row++)
                {
                    var block = GetBlockAt(column, row);
                    block.Draw(column, row);
                }
            }
        }

        public IMapBlock GetBlockAt(int column, int row)
        {
            if (OutOfMapBounds(column, 0, Settings.GAME_COLUMNS)) return null;
            if (OutOfMapBounds(row, 0, Settings.GAME_ROWS)) return null;

            return _map[column, row];

            bool OutOfMapBounds(int value, int minimum, int maximum) =>
                value < minimum || value >= maximum;
        }
    }
}