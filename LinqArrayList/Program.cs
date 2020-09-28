using System;
using System.Collections;
using System.Linq;
using System.Resources;

namespace LinqArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sa = new ArrayList();
            sa.Add(new Staff(1,"Nam",24));
            sa.Add(new Staff(2, "Kien", 21));
            sa.Add(new Staff(3, "Viet", 21));
            sa.Add(new Staff(4, "Hang", 23));
            sa.Add(new Staff(5, "Tien", 24));

            var arrList = sa.OfType<Staff>();
            var arrList1 = from aList in arrList
                         where (aList.Age < 24)
                         select aList;
            foreach (var item in arrList1)
            {
                Console.WriteLine("ID :" + item.Id + " Name : " + item.Name + " Age : " + item.Age);
            }




        }
    }
}
