using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task2
{
    public abstract class Animal: Alive
    {

        protected readonly string name;
        protected Animal(string name = "") 
        {
            this.name = name;   
        }

        public string getName(){

           return name; 
        }
            
       
    }
}
