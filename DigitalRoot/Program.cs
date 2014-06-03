using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("54675566");


        } 
   


        
        static void DigitalRoot(string rootThis)
        {
            while (rootThis > 1)
            {
                rootThis. == rootingFunc;
            }
            

            
          
        }
        static void rootingFunc(string root)
        {
            var total = 0;
            for (var i = 0; i < root.Length; i++)
            {
                var rootNumber = root[i].ToString();
                var number = Convert.ToInt32(rootNumber);
                total = total + number;
            }
            Console.WriteLine(total);

            Console.ReadKey();
        }
    } 
        
   


}
