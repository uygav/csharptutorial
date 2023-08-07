using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chef
    {

        public void MakeChicken()
        {
            Console.WriteLine("the chef makes chicked");
        }
        public void MakeSalad() {
            Console.WriteLine("the chef makes salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("the chef makes bbq ribs");
        }
    }
}
