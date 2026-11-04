using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Lab7._1
{
    internal interface IBall
    {
        int NumberOfPlayers { get; set; }
        string NameOfSoport { get; }

        void SportCharacteristics();
    }
}
