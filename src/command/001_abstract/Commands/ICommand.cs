using System;

namespace Project
{
    interface ICommand
    {
        bool Execute(bool param1, int param2, string param3);
    }
}
