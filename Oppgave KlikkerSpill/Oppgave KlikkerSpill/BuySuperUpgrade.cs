using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_KlikkerSpill
{
    internal class BuySuperUpgrade : ICommand
    {
        public void Run(ClickerGameIntVariables ClickerGameIntVariables) 
        {
            if (ClickerGameIntVariables.points >= 100)
            {
                ClickerGameIntVariables.points -= 100;
                ClickerGameIntVariables.pointsPerClickIncrease++;
                Console.WriteLine($"Du har kjøpt oppgraderingen suksessfult. PointsPerClickIncrease er nå {ClickerGameIntVariables.pointsPerClickIncrease}");
            }
            else
            {
                Console.WriteLine("Du har ikke nok poeng for det");
            }
        }
    }
}
