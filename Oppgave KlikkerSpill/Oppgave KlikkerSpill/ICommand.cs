using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_KlikkerSpill
{
    internal interface ICommand
    {
        void Run(ClickerGameIntVariables ClickerGameIntVariables);
    }
}
