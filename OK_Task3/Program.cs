using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OK_Task3
{
    class Program
    {
            static void Main(string[] args)
            {
            string start;
            string end;
            
           
                Console.WriteLine("Input natural value from: ");
                start = Console.ReadLine();
                Console.WriteLine("Input natural value to: ");
                end = Console.ReadLine();

                int st = int.Parse(start);
                int en = int.Parse(end);
                int count = en - st;    
                int i = 0;
                var NaturalArray = new List<int>();

                for (int j = st; j <= en; j++)
                {
                    NaturalArray.Add(st);
                    st++;
                    i++;
                }

                int sum = 0;

                foreach (var nat in NaturalArray)
            {
                if ((nat % 3 == 0) & (nat % 5 != 0))
                {
                    sum += nat;
                }
            }
{
                Console.WriteLine("Sum = {0}",sum);
             
            }

            Console.ReadKey();


        }
    }
}
