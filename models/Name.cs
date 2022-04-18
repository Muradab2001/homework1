using System;
using System.Collections.Generic;
using System.Text;

namespace homework.models
{
    class Name
    {
        private string _name;
        public int Limit;
        public string Name1
        {
            get => _name;
            set
            {
                bool check = true;
                while (check)
                {
                    bool symbol = false;
                    if (char.IsUpper(value[0]))
                    {
                        foreach (char item in value)
                        {
                            if (char.IsSymbol(item))
                            {
                                symbol = true;
                            }
                        }
                        if (symbol==false)
                        {
                            value = _name;
                            check = false;
                        }
                        else
                        {
                            Console.WriteLine("simbol olmaz");
                            check = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("sirket adi balaca ola bilmez");
                        check = false;
                    }
                }
               
                   
            }
        }
        public Employee[] employess;
        public Name()
        {
            employess = new Employee[0];
        }
        public void Addemployes(Employee employ)
        {
            if (employess.Length<Limit)
            {
                Array.Resize(ref employess, employess.Length + 1);
                employess[employess.Length - 1] = employ;
                return;
            }
            else
            {
                Console.WriteLine("sirketde yer yoxdu");
            }
        }
        public Employee[] getemployes() => employess;
    }
}
