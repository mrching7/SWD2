using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface Object
    {
        //public TrafficLight t;
        void CrossStreet();

        int State();

        int Location();
        //public enum Currentstate
        //{
        //    Driveforward,
        //    Driveright,
        //    Driveleft
        //};
        //public enum CurrentLocation
        //{
        //    North=0,
        //    South=1,
        //    West=2,
        //    East=3
        //};
    }

    public class ConcreteCar : Object
    {

        private int state;
        private int location;

        public int State()
        {
             return state;
        }
        public int Location ()
        {
            return location;
        }
        public ConcreteCar()
        {
            Random rnd= new Random();

            state = rnd.Next(4);

            location = rnd.Next(5);

           
        }

        public void CrossStreet()
        {
            if (location==0)
            {
                if (state==0)
                {
                    Console.WriteLine("Driving forward from north to south");
                }
                else if (state == 1)
                {
                    Console.WriteLine("Turning right from north");
                }
                else if (state == 2) 
                {
                    Console.WriteLine("turning left from north");
                }
            }
            else if (location==1)
            {
                if (state == 0)
                {
                    Console.WriteLine("Driving forward from south to north");
                }
                else if (state == 1)
                {
                    Console.WriteLine("Turning right from south");
                }
                else if (state == 2)
                {
                    Console.WriteLine("turning left from south");
                }
            }
            else if (location == 2)
            {
                if (state == 0)
                {
                    Console.WriteLine("Driving forward from West to east");
                }
                else if (state == 1)
                {
                    Console.WriteLine("Turning right from west");
                }
                else if (state == 2)
                {
                    Console.WriteLine("turning left from west");
                }
            }
            else
            {
                if (state == 0)
                {
                    Console.WriteLine("Driving forward from east to west");
                }
                else if (state == 1)
                {
                    Console.WriteLine("Turning right from east");
                }
                else if (state == 2)
                {
                    Console.WriteLine("turning left from east");
                }
            }
        }


    }


}
