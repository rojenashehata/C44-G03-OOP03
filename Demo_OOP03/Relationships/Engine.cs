using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Relationships
{
    internal class Engine
    {
        public void start() 
        {
            Console.WriteLine();
        }
    }
    //car has engine

    //Composition =>Strong aggregation
    //has a
    public class Car
    {
               private Engine engine=new Engine();
        public Car() 
        {
            engine.start();
        }
    }
}
