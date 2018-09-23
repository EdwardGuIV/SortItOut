using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortItOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            int indexNum; string indexNumS;
            double dubNum; string dubNumS;
            Guid guid; string guidS;

            List<string> genNumL = new List<string>();
            Random r = new Random();

            //Create some array to hold the results as strings 
            for (int x = 0; x < 1000000; x++)
            {
                //add x and a comma
                indexNum = x;
                indexNumS = indexNum.ToString();

                //a Guid using Guid.NewGuid() and a comma
                guid = Guid.NewGuid();
                guidS = guid.ToString();

                //add a randomly generated double 
                dubNum = r.NextDouble();
                dubNumS = dubNum.ToString() + "\r\n";

                //write string to array location x
                genNumL = new List<string> { indexNumS, guidS, dubNumS };

                string results = String.Join(", ", genNumL);
                Console.WriteLine(results);

                string path = @"MyCSVTest.csv";

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, results);
                }
                else
                {
                    File.AppendAllText(path, results);
                }

            }


            /*  public class Item
          {
              public string Name { get; set; }
              public int Quantity { get; set; }
              public int AlertLevel { get; set; }
          }*/

        }
    }
}
