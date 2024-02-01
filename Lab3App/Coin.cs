using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int value;

        public Coin(string description, int score, int value) : base(description, score) 
        { 
            this.value = value;
        }

        public void UpdateTotalValue()
        {
            board.TotalValue += value;
            Console.WriteLine("Total Value is updated to: " + board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + description + " is displayed");
        }

    }
}
