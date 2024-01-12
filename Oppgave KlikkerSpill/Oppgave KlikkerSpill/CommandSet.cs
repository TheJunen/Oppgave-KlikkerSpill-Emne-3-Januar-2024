using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_KlikkerSpill
{
    internal class CommandSet
    {
        ICommand[] AllCommandos = new ICommand[]
        {
                new BuySuperUpgrade(),
                new BuyUpgrade(),
                new Click(),
                new ExitApplication()
        };
        
        public void RunCommand(char command, ClickerGameIntVariables ClickerGameIntVariables)
        {
            foreach (var cmd in AllCommandos)
            {
                if (command == ' ' )
                {
                    AllCommandos[2].Run(ClickerGameIntVariables);
                    return;
                }
                else if (command == 'k')
                {
                    Console.WriteLine("Hei");
                    AllCommandos[1].Run(ClickerGameIntVariables);
                    return;
                }
                else if (command == 's')
                {
                    Console.WriteLine("Hei");
                    AllCommandos[0].Run(ClickerGameIntVariables);
                    return;
                }
                else if (command == 'x')
                {
                    Console.WriteLine("Hei");
                    AllCommandos[3].Run(ClickerGameIntVariables);
                    return;
                }
            }
        }

        
    }
}
