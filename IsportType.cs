using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7._1
{
    internal interface IsportType : IBall, ICourtDimensions
    {
        SportCategory Category { get; }
    }
}
