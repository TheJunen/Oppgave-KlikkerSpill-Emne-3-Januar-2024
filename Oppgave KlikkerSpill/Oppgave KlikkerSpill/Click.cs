using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_KlikkerSpill
{
    internal class Click : ICommand
    {
        public void Run(ClickerGameIntVariables ClickerGameIntVariables) 
        {
            ClickerGameIntVariables.points += ClickerGameIntVariables.pointsPerClick;
            ClickerGameIntVariables.points++;
            Console.WriteLine(ClickerGameIntVariables.points);
        }
    }
}
