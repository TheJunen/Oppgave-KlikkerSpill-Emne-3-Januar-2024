using System.Runtime.ConstrainedExecution;

namespace Oppgave_KlikkerSpill
{
    class Program
    {
        static void Main(string[] args)
        {
            ClickerGameIntVariables ClickerGameIntVariables = new ClickerGameIntVariables();
            CommandSet CommandSet = new CommandSet();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n" +
                "- SPACE = klikk(og få poeng)\r\n" +
                "- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n" +
                "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n" +
                "- X = avslutt applikasjonen");

                Console.WriteLine($"Du har {ClickerGameIntVariables.points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var command = Console.ReadKey().KeyChar;
                CommandSet.RunCommand(command, ClickerGameIntVariables);
            }
        }
    }
}
