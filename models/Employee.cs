using System;
using System.Collections.Generic;
using System.Text;

namespace homework.models
{
    class Employee
    {
        private static int id = 1;
        public string Fullname;
        public int Salary;
        public string Position;

        public int No;
        public Employee(string fullname,int salary,string position)
        {
            No = id;
            id++;
            Fullname = fullname;
            Salary = salary;
            Position = position;
        }
        
    }
}
