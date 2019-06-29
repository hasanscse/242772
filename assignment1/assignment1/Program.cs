using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Address : ");
            string address = Console.ReadLine();

            Console.WriteLine("Please Enter Your Phone No : ");
            string phone = Console.ReadLine();

            Console.WriteLine("Please Enter Your Date of Birth :");
            string birth = Console.ReadLine();

            Console.WriteLine("Please Enter Your Age :");
            string age = Console.ReadLine();


            Console.WriteLine("Your Information" );
            Console.WriteLine("Your Name:" + name);
            Console.WriteLine("Your Address:" + address);
            Console.WriteLine("Your Phone Number:" + phone);
            Console.WriteLine("Your Birthday:" + birth);
            Console.WriteLine("Your Age:" + age);

            Console.ReadKey();


        }
    }
}
