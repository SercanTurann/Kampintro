using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectN
{
    internal interface IGames
    {
        void Add(TheGame theGame);
        void Delete(TheGame theGame);
        void Update(TheGame theGame);
    }
}
