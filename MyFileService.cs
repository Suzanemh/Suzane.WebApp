using Suzane.WebApp;
using System.Collections.Generic;

namespace Suzane.WebApp
{
   
    public class MyFileService : IMyFileService
    {
        public IEnumerable<string> ReadMyFile(string filePath)
        {


            var lines = File.ReadAllLines(filePath);

            //Legge til signatur på siste linje
            var newEnumerable = lines.Append("Signatur: Suzane");


            //bruk av toList
            var newList = newEnumerable.ToList();

            //bruk av ToArray
            var newArray = newEnumerable.ToArray();

            return newEnumerable;



        }
    }
}