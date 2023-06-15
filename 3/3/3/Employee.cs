using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Employee
    {
        public string _fio;
        public double _salary;
        public int _department;
        static public int id = 1;
        public int Id
        {
            get => id++;
        }
        public int IdR()
        {
            id = 1;
            return id;
        }

        public Employee(string fio, int salary, int department)
        {

            _fio = fio;
            _salary = salary;
            _department = department;
        }

        public Employee()
        {
        }

        public string Fio
        {
            get => _fio;
            set => _fio = value;
        }
        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public int Department
        {
            get => _department;
            set => _department = value;
        }
    }
}
