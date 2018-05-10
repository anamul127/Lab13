using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Rocky : Player
    {
        override public Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
