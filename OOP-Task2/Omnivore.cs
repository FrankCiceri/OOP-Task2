using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task2
{
    public abstract class Omnivore:Animal
    {
        protected Omnivore(string name) : base(name)
        {
        }

        public virtual void Eat(Herbal herb)
        {
            Console.WriteLine(Species + " Eating " + herb.NameOfSpecies());
        }

        public virtual void Eat(Animal ani)
        {
            Console.WriteLine(Species +" Eating " + ani.NameOfSpecies());
        }

        protected override string Type { get { return "Omnivore"; } }


    }
}
