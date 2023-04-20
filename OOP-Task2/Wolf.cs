using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task2
{
    internal class Wolf : Carnivore
    {
        public Wolf(string name) : base(name)
        {

        }

        protected override string Species {get{ return "Wolf"; } }

        
    }
}
