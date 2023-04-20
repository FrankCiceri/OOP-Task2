namespace OOP_task2
{
     public abstract class Alive
    {
        protected abstract string Species { get; }
        protected virtual string Type { get; }

        public virtual string NameOfSpecies() {
            return Species;
        }

        public virtual string NameOfType() { 
        
            return Type;
        }
        


    }
}