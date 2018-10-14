using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {

            IOManager.printConsole("Type: \"exit\" to quit");

            while (true)
            {

                string searchText = IOManager.UserInput();
                if (searchText == "exit")
                {
                    System.Environment.Exit(1);
                }

                SearchManager.SearchRut(searchText);
                SearchManager.print();
            }
        }
    }
}
