using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            List <ConcreteCar> C = new List<ConcreteCar>();
            ConcreteCar C1=new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C2 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C3 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C4 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C5 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C6 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C7 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C8 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C9 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C10 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C11 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C12 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C13 = new ConcreteCar();
            Thread.Sleep(20);
            ConcreteCar C14 = new ConcreteCar();
            C.Add(C1);
            C.Add(C2);
            C.Add(C3);
            C.Add(C4);
            C.Add(C5);
            C.Add(C6);
            C.Add(C7);
            C.Add(C8);
            C.Add(C9);
            C.Add(C10);
            C.Add(C11);
            C.Add(C12);
            C.Add(C13);
            C.Add(C14);

            ConcreteTrafficLight concreteTraffic=new ConcreteTrafficLight(C);

            concreteTraffic.NotifyForward();
            Thread.Sleep(2000);
            concreteTraffic.NotifyForward2();

        }
    }
}
