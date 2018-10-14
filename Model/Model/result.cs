using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Result
    {
        string name;
        string rut;

        public Result(string name, string rut)
        {
            this.name = name;
            this.rut = rut;
        }

        public void printInfo()
        {
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Rut: " + rut);
        }
    }
}
