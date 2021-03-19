using AbstractFactory;
using Facade;
using Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new ClientAbstractFactory().Main(); //AbstractFactory
            new ClientFacade().Main();          //Facade
            new ClientObserver().Main();        //Observer

            Console.ReadKey();
        }
    }
}
