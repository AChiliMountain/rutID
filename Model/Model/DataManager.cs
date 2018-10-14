using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
    public class DataManager
    {

        List<string> resultList;
        string filename;
        
        public DataManager()
        {
            this.resultList = new List<string>();
        }


        public void OpenCSV(string fileName)
        {
            StreamReader reader = new StreamReader(File.OpenRead(fileName));
            this.filename = fileName;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                resultList.Add(line);
            }
        }

        public void WriteCSV(List<Result> resultList)
        {

            using (var stream = File.CreateText("out_" + filename))
            {

                foreach (Result result in resultList)
                {
                    stream.WriteLine($"{result.GetRut()};{result.GetName()}");
                }
            }

        }



        public List<string> GetDataList()
        {
            return resultList;
        }

    }
}
