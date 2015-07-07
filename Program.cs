using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_15_ExperIT_SpaceExploration
{
    class Program
    {
        static void Main(string[] args)
        {

              double shipSpeed = 10000;
              double increaseVelocity = 0.05;
      
            // 30 sec boost for 5 mins = 10 times
            for(int x=0;x<10;x++)
            {
                shipSpeed = shipSpeed+(shipSpeed*increaseVelocity);
            }


            Console.WriteLine("The ship speed after 5 mins of boost is " + shipSpeed);



            shipSpeed = 10000;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    shipSpeed = shipSpeed + (shipSpeed * increaseVelocity);
                }
            }

            Console.WriteLine("The ship speed after 2hrs of boost is " + shipSpeed);
            Console.ReadLine();




        }
    }
}
