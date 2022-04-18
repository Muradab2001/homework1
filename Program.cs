using System;
using homework.models;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empo1 = new Employee("murad",1400,"full stack developer");
            Employee empo2 = new Employee("murad", 1400, "full stack developer");
            Name company = new Name();
            company.Limit = 1;
            company.Name1 = "Cod akademi";
            company.Addemployes(empo1);
            company.Addemployes(empo2);


        }
    }
}
