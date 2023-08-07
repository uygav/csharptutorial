using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string name = "uygar muntas";
            //int age;
            //age = 20;
            //age++;
            //char grade = 'A';
            //double number2 = 3.3;
            //bool isMale = true;

            //Console.WriteLine("my name is " + name +"my age is "+age );

            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.Contains("uygar"));
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name.IndexOf("uygar"));
            //Console.WriteLine(name.IndexOf('y'));
            //Console.WriteLine(name.Substring(8,3));
            //Console.WriteLine(Math.Abs(-31));
            //Console.WriteLine(Math.Sqrt(36));
            //Console.Write("enter random name : ");
            //string getInput = Console.ReadLine();
            //Console.WriteLine("hello " + getInput);

            //int number1 = Convert.ToInt32("31");
            //Console.WriteLine(number1 + number2);

            //int number3 = Convert.ToInt32(Console.ReadLine());
            //int number4 = Console.ReadLine(); getting error bc Console.ReadLine = string

            //string color1, color2;
            //color1 = "red";
            //color2 = "blue";


            //int[] arrayNumbers = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(arrayNumbers[0]);
            //arrayNumbers[1] = 27;

            //string[] friends = new string[5];
            //friends[0] = "ryan gosling";



            //Console.WriteLine(name);
            //Console.Write("31");
            //Console.WriteLine("31");
            //Console.WriteLine("uygar");

            SayHi("uygar", 21);
            Console.WriteLine(cube(3));

            int index = 1;
            while(index <= 5)
            {
                //Console.WriteLine(index);
                index++;
            }

            for(int i = 1; i <= 5; i++)
            {
                //Console.WriteLine(i);
            }

            int[] numberarray = { 1, 2,3,4,5,6 };
            for(int i = 0; i< numberarray.Length; i++)
            {
                //Console.WriteLine(i);
            }

            int[,] TWODarray = {
                {1,2},
                {3,4},
                {5,6}
            };
            Console.WriteLine(TWODarray[1,1]);
            int[,] myarray = new int[2, 3]; 

            // try catch


            Book book1 = new Book("harry poter","idk",400); // this is an object

            //book1.title = "harry poter";
            //book1.author = "idk";
            //book1.pages = 400;

            Book book2 = new Book("lotr","idk",700);
            //book2.title = "lotr";
            //book2.author = "idk";
            //book2.pages = 700;

            Console.WriteLine(book1.title);

            book2.title = book1.title;

            Console.WriteLine(book2.title);

            
            Student student1 = new Student("jim","business",2.8);
            Student student2 = new Student("pam", "art", 3.6);


            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());


            Movie avengers = new Movie("the avengers", "joss whedon", "PG-13");
            Movie shrek = new Movie("shrek", "adam adamson", "PG");

            Console.WriteLine(avengers.Rating);
            shrek.Rating = "cat";
            Console.WriteLine(shrek.Rating);

            Song holiday = new Song("holiday", "green day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("kashmir","led zeppelin",150);
            Console.WriteLine(Song.songCount);


            Chef chef = new Chef();
            chef.MakeChicken();

            TurkishChef turkishChef = new TurkishChef();
            turkishChef.MakeChicken();
            turkishChef.MakeLahmacun();



            Console.ReadLine();

            

        }

        static void SayHi(string name,int age)
        {
            Console.WriteLine("hello " + name + " you are " + age + " years old");
        }
        static int cube(int number)  // this int is return type
        {
            int result = number * number * number;
            return result;
        }
        static string SwitchCase(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "A"; 
                    break;
                case 1:
                    dayName = "B";
                    break;
                case 2:
                    dayName = "C";
                    break;
                default: 
                    dayName = "D";
                    break;

            }
            return dayName;

        }
        
        
    }
}
