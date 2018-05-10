using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Human : Player
    {
        public Human()
        {

        }
        override public Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Rock(0), paper(1), or scissors(2)?(R/P/S)");
            int input1 = int.Parse(Console.ReadLine());

            if (input1 == 0)
            {
                return Roshambo.Rock;
            }
            else if (input1 == 1)
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissor;
            }
            ////else
            //{
            //    Console.WriteLine("Invalid input");
            //}
        }
    }
}
