using System;
using System.Collections.Generic;
using System.IO;

namespace SortItOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            //
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

                //format the strings for printing
                string results = String.Join(", ", genNumL);
                Console.WriteLine(results);

                //create file path 
                string path = @"MyCSVTest.csv";

                //see if the file exists before making a new one
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, results);
                }
                //if the file exists append the other text
                else
                {
                    File.AppendAllText(path, results);
                }

                //trying to read text as it is or after it is written
                //string readText = File.ReadAllText(path);
                //foreach (var item in readText)
                //{
                //    Console.WriteLine(item);

                //}
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
