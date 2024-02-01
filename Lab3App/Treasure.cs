using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        private int score;

        public Treasure(string description, int score) : base(description)
        {
            this.score = score;
        }

        public void UpdateTotalScore()
        {
            board.TotalScore += score;
            Console.WriteLine("Total Score is updated to: "+ board.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore();
        }
    }

    
}
