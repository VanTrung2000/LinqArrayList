using System;
using System.Collections.Generic;
using System.Text;

namespace LinqArrayList
{
    class Staff
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public Staff() { }
        public Staff(int Id,string Name,int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
    }
}
