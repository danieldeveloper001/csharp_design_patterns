using System;
using System.IO;

namespace Project
{
    //TODO: VALIDATE REFACTORED CODE FOR BOUNDARIES INDEX ERROR (+1 OR -1)

    public class Map
    {
        private MapBlockFactory _mapBlockFactory;
        private IMapBlock[,] _map;
        private int _columns;
        private int _rows;

        public Map(MapBlockFactory mapBlockFactory, int columns, int rows)
        {
            _map = new IMapBlock[columns, rows];
            _columns = columns;
            _rows = rows;

            _mapBlockFactory = mapBlockFactory;
        }

        public void Draw()
        {
            for (int column = 0; column < _columns; column++)
            {
                for(int row = 0; row < _rows; row++)
                {
                    var block = GetBlockAt(column, row);
                    block.Draw(column, row);
                }
            }
        }

        public void Load(string path)
        {
            using (var reader = new StreamReader(path))
            {
                var rowIndex = 0;
                while (reader.ReadLine() is string row)
                {
                     var columnIndex = 0;
                     while(columnIndex < row.Length && row[columnIndex] is char column)
                     {
                        _map[columnIndex, rowIndex] = _mapBlockFactory.GetMapBlock(column);
                        columnIndex++;
                     }
                     rowIndex++;
                }
            }
        }

        public IMapBlock GetBlockAt(int column, int row)
        {
            if (column < 0 || column >= _columns)
                return null;

            if (row < 0 || row >= _rows)
                return null;

            return _map[column, row];
        }

    }
}