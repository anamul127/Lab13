using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Rand : Player
    {
        static Random rnd = new Random();

        override public Roshambo GenerateRoshambo()
        {
            int Roro = rnd.Next (0, 3);
            return (Roshambo)Roro;
        }

    }

}
