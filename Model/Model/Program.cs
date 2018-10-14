using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {

            DataManager dataManager = new DataManager();
            dataManager.OpenCSV("data.csv");
            List<string> dataList = dataManager.GetDataList();
            List<Result> resultList = new List<Result>();
            foreach(string rut in dataList)
            {
                if (rut is null) { continue; }
                SearchManager.SearchRut(rut);
                SearchManager.print();
            }

            resultList = SearchManager.resultList;
            dataManager.WriteCSV(resultList);
            IOManager.printConsole("Writing CSV File");
            Console.ReadLine();




        }
    }
}
