using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesConsole
{
    class Badges
    {
        static void Main(string[] args)
        {
           
            ProgramUI userInterface = new ProgramUI();

            userInterface.Run();
            Console.ReadKey();
        }


    }


}
