using System;
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
                var row = 0;
                while (reader.ReadLine() is string dataRow)
                {
                     var column = 0;
                     while(column < dataRow.Length && dataRow[column] is char dataColumn)
                     {
                        _map[column, row] = _mapBlockFactory.GetMapBlock(dataColumn);
                        column++;
                     }
                     row++;
                }
            }
        }

        public void Draw()
        {
            var _columns = _map.GetLength(0);
            var _rows = _map.GetLength(1);

            for (int column = 0; column < _columns; column++)
            {
                for(int row = 0; row < _rows; row++)
                {
                    var block = GetBlockAt(column, row);
                    block.Draw(column, row);
                }
            }
        }

        public IMapBlock GetBlockAt(int column, int row)
        {
            if (column < 0 || column >= Settings.GAME_COLUMNS)
                return null;

            if (row < 0 || row >= Settings.GAME_ROWS)
                return null;

            return _map[column, row];
        }

    }
}