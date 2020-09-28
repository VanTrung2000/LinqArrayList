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
            var sapxep = from aList1 in arrList
                         where (aList1.Age < 24)
                         orderby aList1.Name
                         select aList1;

            foreach (var item in arrList1)
            {
                Console.WriteLine("ID :" + item.Id + " Name : " + item.Name + " Age : " + item.Age);
            }
             Console.WriteLine("Sap xep theo ten :");
            foreach (var item in sapxep)
            {
                Console.WriteLine("ID :" + item.Id + " Name : " + item.Name + " Age : " + item.Age);
            }




        }
    }
}
