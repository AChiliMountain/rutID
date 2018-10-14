using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    static public class IOManager
    {

        static public void Input(string text)
        {
            printConsole(text);
        }

        static public void printConsole(string text)
        {
            Console.WriteLine(text);
        }
        static public string UserInput()
        {
            Console.Write(":> ");
            string text = Console.ReadLine();
            return text;
        }

    }
}
