using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoConsole
{
    class ClaimProgram
    {
        static void Main(string[] args)
        {
            ClaimProgramUI userInterface = new ClaimProgramUI();

            userInterface.Run();
            Console.ReadKey();
        }
    }
}
