using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced2
{
    internal class Employee :IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public Employee() { }   
        public Employee(int id, string name, int salary){
            Id = id;
            Name = name;
            this.salary= salary;
}
        public override string ToString()
        {
            return $"{Id}:{Name}:{salary} ";
        }

        public int CompareTo(Employee? other)
        {
            return this.Id.CompareTo(Id);
        }
    }
}
