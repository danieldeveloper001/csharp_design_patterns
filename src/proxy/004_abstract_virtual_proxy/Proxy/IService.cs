using System;

namespace Project
{
    public interface IService
    {
        bool TryGet(int rowIndex, out string rowData);
    }
}