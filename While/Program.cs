using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        { //Övning 1
           
            int i = 0;
            while (i < 100)
            {
                i++;
                Console.WriteLine(i);
            }
            //Övning 2
            Console.WriteLine("Mata in ditt lösenord");
            var password = Console.ReadLine();
           
                while (password != "Aron")
            {
                Console.WriteLine("Mata in igen");
                password = Console.ReadLine();
            }
               //Övning 3
               
         
            
            
        }
    }
}
