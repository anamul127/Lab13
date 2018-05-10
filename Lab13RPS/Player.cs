using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    abstract class Player
    {
        public string name;
        public Roshambo Roshambo;

        //public Player(string name, Roshambo roshambo)
        //{
        //    this.name = name;
        //    Roshambo = roshambo;
        //}

        abstract public Roshambo GenerateRoshambo();
    }
}

