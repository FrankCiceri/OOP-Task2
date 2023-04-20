using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task2
{
    public abstract class Carnivore : Animal
    {
        protected Carnivore(string name) : base(name)
        {
        }



        public void Eat(Animal ani)
        {
            Console.WriteLine(Species +" Eating " + ani.NameOfSpecies());
        }

        protected override string Type { get { return "Carnivore"; } }

      

    }
}
