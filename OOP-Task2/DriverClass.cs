using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task2
{
    public class DriverClass
    {
        public static void Main(string[] args)
        {
            Wolf wolf = new Wolf("Doggy");
            Console.WriteLine(wolf.getName());
            Console.WriteLine(wolf.NameOfSpecies());
            Console.WriteLine(wolf.NameOfType()+"\n");


            Bear bear = new Bear("Yogi");
            Console.WriteLine(bear.getName());
            Console.WriteLine(bear.NameOfSpecies());
            Console.WriteLine(bear.NameOfType() + "\n");

            Rabbit rabbit = new Rabbit("Roger");
            Console.WriteLine(rabbit.getName());
            Console.WriteLine(rabbit.NameOfSpecies());
            Console.WriteLine(rabbit.NameOfType() + "\n");

            Rose rose = new Rose();
            Console.WriteLine(rose.NameOfSpecies());
            Console.WriteLine(rose.NameOfType() + "\n");

            Grass grass = new Grass();
            Console.WriteLine(grass.NameOfSpecies());
            Console.WriteLine(grass.NameOfType() + "\n");


            bear.Eat(rose);
            bear.Eat(grass);
            bear.Eat(rabbit);
            rabbit.Eat(rose);
            //rabbit.Eat(wolf); this will produce error
            wolf.Eat(rabbit);
            //wolf.Eat(grass); this will produce error

        }


    }
}
