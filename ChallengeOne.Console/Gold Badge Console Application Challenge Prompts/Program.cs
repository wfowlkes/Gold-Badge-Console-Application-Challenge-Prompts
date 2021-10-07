using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Badge_Console_Application_Challenge_Prompts
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUi userInterface = new ProgramUi();

            userInterface.Run();
            Console.ReadKey();
        }
        //Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list
    }
}
