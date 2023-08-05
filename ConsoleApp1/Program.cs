using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "uygar muntas";
            int age;
            age = 20;
            age++;
            char grade = 'A';
            double number2 = 3.3;
            bool isMale = true;

            Console.WriteLine("my name is " + name +"my age is "+age );

            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Contains("uygar"));
            Console.WriteLine(name[1]);
            Console.WriteLine(name.IndexOf("uygar"));
            Console.WriteLine(name.IndexOf('y'));
            Console.WriteLine(name.Substring(8,3));
            Console.WriteLine(Math.Abs(-31));
            Console.WriteLine(Math.Sqrt(36));
            Console.Write("enter random name : ");
            string getInput = Console.ReadLine();
            Console.WriteLine("hello " + getInput);


            //Console.WriteLine(name);
            //Console.Write("31");
            //Console.WriteLine("31");
            //Console.WriteLine("uygar");


            Console.ReadLine();

        }
    }
}
