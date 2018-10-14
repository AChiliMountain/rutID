using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Model
{
    static public class SearchManager
    {
        static string rut = String.Empty;
        static WebClient web = new WebClient();

        static public void SearchRut(string rut)
        {
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            SearchManager.rut = rut;
        }


        static public void print()
        {
            System.IO.Stream stream = web.OpenRead($"https://api.rutify.cl/search?q={rut}");
            using (System.IO.StreamReader reader = new StreamReader(stream))
            {
                string text = reader.ReadToEnd();
                string[] data = text.Trim('[','{', '}',']').Split(',');
                try
                {
                    Result result = new Result(data[0].Split(':')[1], data[1].Split(':')[1]);
                    result.printInfo();
                }
                catch
                {
                    IOManager.printConsole("Error Found!");
                }
            }
            
        }
    }
    
}
