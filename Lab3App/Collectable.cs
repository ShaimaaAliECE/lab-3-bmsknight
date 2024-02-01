using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        protected string description;
        protected CollectionBoard board;

        public CollectionBoard Board
        { 
            get { return board; }
            set { board = value; }
        }

        /*
        public string Description { 
            get { return description; } 
            set { description = value; } 
        }
        */

        public Collectable(string description)
        {
            this.description = description;
        }

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(description + " Collected, Congrats!!!!");
        }

        public abstract void Display();
    }
}
