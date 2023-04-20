using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task2
{
    public abstract class Herbivore : Animal
    {
        protected Herbivore(string name) : base(name)
        {
        }

        protected override string Type { get { return "Herbivore"; } }

        public void Eat(Herbal herb)
        {
            Console.WriteLine(Species + " Eating " + herb.NameOfSpecies());
        }


    }
}
