using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //int a,b,sum,sub,mult;
         //a=Convert.ToInt32(Console.ReadLine());
         //b = Convert.ToInt32(Console.ReadLine());

            int userinput;
            userinput = Convert.ToInt32(Console.ReadLine());
            //if (userinput==1)
            //{
            //    sum = a + b;
            //    Console.WriteLine("your sum numer is "+sum);
            //}
            //else if(userinput==2)
            //{
            //    sub = a - b;
            //    Console.WriteLine("your sub numer is " +sub);
            //}
            //else if(userinput==3)
            //{
            //    mult = a * b;
            //    Console.WriteLine("your  numer is "+ mult);
            //}
            //else
            //{
            //    Console.WriteLine("success");
            //}
                
            switch(userinput % 2)
            {
                case 0:
                    Console.WriteLine("your numer is  even");
                    break;
                case 1:
              
                    Console.WriteLine("your  numer is odd" );
                    break;
                default:
                    Console.WriteLine("false number");
                    break;
            }
            

            Console.ReadKey();//Black screen hold

        }
    }
}
