using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_KlikkerSpill
{
    internal class BuyUpgrade : ICommand
    {
        public void Run(ClickerGameIntVariables ClickerGameIntVariables)
        {
            if (ClickerGameIntVariables.points >= 10)
            {
                ClickerGameIntVariables.points -= 10;
                ClickerGameIntVariables.pointsPerClick += ClickerGameIntVariables.pointsPerClickIncrease;
                Console.WriteLine($"Du har kjøpt oppgraderingen suksessfult. PointsPerClick er nå {ClickerGameIntVariables.pointsPerClick}");
            }
            else
            {
                Console.WriteLine("Du har ikke nok poeng for det");
            }
        }
    }
}