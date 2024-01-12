using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_KlikkerSpill
{
    internal class ExitApplication : ICommand
    {
        public void Run(ClickerGameIntVariables ClickerGameIntVariables)
        {
            Environment.Exit(0);
        }         
    }
}
