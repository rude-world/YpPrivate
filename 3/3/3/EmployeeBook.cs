using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class EmployeeBook : Employee
    {
        private EmployeeBook(string fio, int salary, int department) : base(fio, salary, department)
        {

            _fio = fio;
            _salary = salary;
            _department = department;
        }
        public EmployeeBook()
        {
        }

        public List<EmployeeBook> _List(EmployeeBook employee)
        {
            List<EmployeeBook> employees = new List<EmployeeBook>()
            {
                new("Иванов Иван Иванович", 10000, 5),
                new("Петров Петр Петрович", 20000, 5),
                new("Андреев Андрей Андреевич", 30000, 4),
                new("Федоров Федор Федорович", 40000, 4),
                new("Борисов Борис Борисович", 50000, 3),
                new("Викторов Виктор Викторович", 60000, 3),
                new("Артемов Артем Артемович", 70000, 2),
                new("Рыбов Рыба Рыбович", 80000, 2),
                new("Романов Роман Романович", 90000, 1),
                new("Лыбов Лыба Лыбович", 99000, 1)
            };
            employee.IdR();
            return employees;
        }


        //задание a
        public void PrintInfo(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine();
            Console.WriteLine("Список информации о сотрудниках:" + "\n");
            foreach (var emp in employees)
            {
                //Console.WriteLine($"{emp.Fio}   Зарплата: {emp.Salary}  Отдел:{emp.Department}");
                Console.WriteLine((employees.IndexOf(emp) + 1) + "\t" + emp.Fio + "\t" + emp.Salary + " руб." + "\t" + emp.Department + " отдел");
            }
            employee.IdR();
            Console.WriteLine();
        }


        //задание b
        public void SumSalary(List<EmployeeBook> employees)
        {
            double sum = 0;
            foreach (var emp in employees)
            {
                sum += emp.Salary;
            }
            Console.WriteLine($"Сумма затрат на зарплату: {sum} руб.");
            Console.WriteLine();
        }


        //задание c
        public void MinSalary(List<EmployeeBook> employees)
        {
            double min = 250000;
            string minemp = "";
            foreach (var emp in employees)
            {
                if (emp.Salary < min)
                {
                    min = emp.Salary;
                    minemp = emp.Fio;
                }
            }
            Console.WriteLine($"Сотрудник с минимальной зарплатой: {minemp} ({min} руб.)");
            Console.WriteLine();
        }


        //задание d
        public void MaxSalary(List<EmployeeBook> employees)
        {
            double max = 0;
            string maxemp = "";
            foreach (var emp in employees)
            {
                if (emp.Salary > max)
                {
                    max = emp.Salary;
                    maxemp = emp.Fio;
                }
            }
            Console.WriteLine($"Сотрудник с максимальной зарплатой: {maxemp} ({max} руб.)");
            Console.WriteLine();
        }


        //задание e
        public void AverageSalary(List<EmployeeBook> employees)
        {
            double sum = 0;
            foreach (var emp in employees)
            {
                sum += emp.Salary;
            }
            Console.Write("Средняя зарплата: ");
            Console.WriteLine(Math.Round((sum / employees.Count), 2) + " руб.");
            Console.WriteLine();
        }


        //задание f
        public void PrintFio(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine("Список сотрудников:" + "\n");
            foreach (var emp in employees)
            {
                Console.WriteLine(employee.Id + "\t" + emp.Fio);
            }
            employee.IdR();
            Console.WriteLine();
        }


        //блок 2
        //1
        public void SalaryChange(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine("Проиндексированная зарплата всех сотрудников");
            Console.Write("Введите величину аргумента: ");
            double arg = Convert.ToDouble(Console.ReadLine());
            foreach (var emp in employees)
            {
                emp.Salary = emp.Salary + (emp.Salary * arg * 0.01);
                Console.WriteLine(employee.Id + "\t" + emp.Fio + "\t" + emp.Salary + " руб.");
            }
            employee.IdR();
        }


        //2
        public void Departmet(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.Write("Введите номер отдела: ");
            string dep = Console.ReadLine();
            Console.WriteLine();
            switch (dep)
            {
                case "1":
                    MinSalaryDep(1, employees);
                    MaxSalaryDep(1, employees);
                    AverageSalaryDep(1, employees);
                    SalaryChangeDep(1, employees, employee);
                    PrintFioDep(1, employees, employee);
                    break;

                case "2":
                    MinSalaryDep(2, employees);
                    MaxSalaryDep(2, employees);
                    AverageSalaryDep(2, employees);
                    SalaryChangeDep(2, employees, employee);
                    PrintFioDep(2, employees, employee);
                    break;

                case "3":
                    MinSalaryDep(3, employees);
                    MaxSalaryDep(3, employees);
                    AverageSalaryDep(3, employees);
                    SalaryChangeDep(3, employees, employee);
                    PrintFioDep(3, employees, employee);
                    break;

                case "4":
                    MinSalaryDep(4, employees);
                    MaxSalaryDep(4, employees);
                    AverageSalaryDep(4, employees);
                    SalaryChangeDep(4, employees, employee);
                    PrintFioDep(4, employees, employee);
                    break;

                case "5":
                    MinSalaryDep(5, employees);
                    MaxSalaryDep(5, employees);
                    AverageSalaryDep(5, employees);
                    SalaryChangeDep(5, employees, employee);
                    PrintFioDep(5, employees, employee);
                    break;
            }
            Console.WriteLine();
        }


        //Минимальная зарплата по отделу
        void MinSalaryDep(int i, List<EmployeeBook> employees)
        {
            double min = 250000;
            foreach (var emp in employees)
            {
                if (emp.Department == i)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
            }
            foreach (var emp in employees)
            {
                if (emp.Department == i)
                {
                    if (emp.Salary == min)
                    {
                        Console.WriteLine("Сотрудник с минимальной зарплатой по отделу: " + emp.Fio + " (" + (min) + ")" + " руб.");
                    }
                }
            }
        }


        //Максимальная зарплата по отделу
        void MaxSalaryDep(int i, List<EmployeeBook> employees)
        {
            double max = 0;
            foreach (var emp in employees)
            {
                if (emp.Department == i)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                    }
                }
            }
            foreach (var emp in employees)
            {
                if (emp.Department == i)
                {
                    if (emp.Salary == max)
                    {
                        Console.WriteLine("Сотрудник с максимальной зарплатой по отделу: " + emp.Fio + " (" + (max) + ")" + " руб.");
                    }
                }
            }
            Console.WriteLine();
        }


        //Средняя зарплата по отделу            
        void AverageSalaryDep(int i, List<EmployeeBook> employees)
        {
            int p = 0;
            double sum = 0;
            foreach (var emp in employees)
            {
                if (emp.Department == i)
                {
                    p++;
                    sum += emp.Salary;
                }
            }
            Console.WriteLine($"Средняя зарплата по отделу: {sum / p} руб.");
            Console.WriteLine();
        }


        //Проиндексированная зарплата сотрудников отдела
        void SalaryChangeDep(int i, List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine("Проиндексированная зарплата сотрудников отдела");
            Console.Write("Введите величину аргумента: ");
            double arg = Convert.ToDouble(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Department == i)
                {
                    emp.Salary = emp.Salary + (emp.Salary * arg * 0.01);
                    Console.WriteLine(emp.Id + "\t" + emp.Fio + "\t" + emp.Salary + " руб.");
                }
            }
            employee.IdR();
            Console.WriteLine();
        }


        //Все сотрудники отдела
        void PrintFioDep(int i, List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine("Все сотрудники отдела:");
            foreach (var emp in employees)
            {
                if (emp.Department == i)
                {
                    Console.WriteLine(emp.Id + "\t" + emp.Fio + "\t" + emp.Salary + " руб.");
                }
            }
            employee.IdR();
        }


        //параметр            
        //1)
        public void ParamentB(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.Write("Введите число: ");
            double sm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Сотрудники с зарплатой больше числа: ");
            foreach (var emp in employees)
            {
                if (sm < emp.Salary)
                {
                    Console.WriteLine(emp.Id + "\t" + emp.Fio + "\t" + "(" + (emp.Salary) + ")" + " руб.");
                }
                else
                {
                    Console.WriteLine("Таковы отсутствуют");
                }
            }
            employee.IdR();
            Console.WriteLine();
        }

        //2)
        public void ParamentS(List<EmployeeBook> employees)
        {
            Console.Write("Введите число: ");
            double sm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Сотрудники с зарплатой меньше числа: ");
            foreach (var emp in employees)
            {
                if (sm >= emp.Salary)
                {
                    Console.WriteLine(emp.Id + "\t" + emp.Fio + "\t" + "(" + (emp.Salary) + ")" + " руб.");
                }
                else
                {
                    Console.WriteLine("Таковы отсутствуют");
                }
            }
        }


        //Поиск сотрудника
        public int Search(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine("Введите ФИО или id сотрудника: ");
            string _search = Console.ReadLine();
            foreach (var emp in employees)
            {
                if (_search == emp.Fio | _search == Convert.ToString(emp.Id))
                {
                    Console.WriteLine((emp.Id - 1) + "\t" + emp.Fio + "\t" + emp.Department);
                    int a = employees.IndexOf(emp);
                    return a;
                }
            }
            employee.IdR();
            return 0;
        }


        //Удаление сотрудника
        public void Delete(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine("Хотите удалить сотрудника? Y/N");
            char ___ans = Convert.ToChar(Console.ReadLine());
            if (___ans == 'Y' | ___ans == 'y')
            {
                int b = employee.Search(employees, employee);
                employees[b] = new("0", 0, 0);

                employee.PrintInfo(employees, employee);
            }
        }


        //Добавить сотрудника
        public void InsEmp(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine("Хотите добавить сотрудника? Y/N");
            char __ans = Convert.ToChar(Console.ReadLine());
            if (__ans == 'Y' | __ans == 'y')
            {
                Console.WriteLine("Добавление нового сотрудника: ");
                Console.WriteLine("Введите новое фио ");
                string fio_ = Console.ReadLine();
                Console.WriteLine("Введите зп нового сотрудника ");
                int salary_ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите отдел нового сотрудника ");
                int department_ = Convert.ToInt32(Console.ReadLine());
                bool r = false;
                foreach (var emp in employees)
                {
                    if (emp.Fio == "0")
                    {
                        r = true;
                        int m = employees.IndexOf(emp);
                        employees[m] = new(fio_, salary_, department_);
                        break;
                    }
                }
                if (r == false)
                {
                    employees.Add(new(fio_, salary_, department_));
                }
                employee.PrintInfo(employees, employee);
            }
        }


        //Изменить сотрудника
        public void Change(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine("Хотите изменить сотрудника? Y/N");
            char _ans = Convert.ToChar(Console.ReadLine());
            if (_ans == 'Y' | _ans == 'y')
            {
                int b = employee.Search(employees, employee);
                Console.WriteLine("Хотите изменить зарплату сотрудника? Y/N");
                string ans = Console.ReadLine();
                if (ans == "Y" | ans == "y")
                {
                    Console.WriteLine("Введите новую зарплату: ");
                    employees[b].Salary = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Хотите изменить отдел сотрудника? Y/N");
                string ans2 = Console.ReadLine();
                if (ans2 == "Y" | ans2 == "y")
                {
                    Console.WriteLine("Введите новый отдел: ");
                    employees[b].Department = Convert.ToInt32(Console.ReadLine());
                }

                employee.PrintInfo(employees, employee);
            }
        }


        //Вывести фио сотрудников по отделам
        public void PrintDepart(List<EmployeeBook> employees, EmployeeBook employee)
        {
            Console.WriteLine();
            Console.WriteLine("Сотрудники 1 отдела: ");
            foreach (var emp in employees)
            {
                if (emp.Department == 1)
                {
                    Console.WriteLine(emp.Fio);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Сотрудники 2 отдела: ");
            foreach (var emp in employees)
            {
                if (emp.Department == 2)
                {
                    Console.WriteLine(emp.Fio);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сотрудники 3 отдела: ");
            foreach (var emp in employees)
            {
                if (emp.Department == 3)
                {
                    Console.WriteLine(emp.Fio);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сотрудники 4 отдела: ");
            foreach (var emp in employees)
            {
                if (emp.Department == 4)
                {
                    Console.WriteLine(emp.Fio);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сотрудники 5 отдела: ");
            foreach (var emp in employees)
            {
                if (emp.Department == 5)
                {
                    Console.WriteLine(emp.Fio);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сотрудники 6 отдела: ");
            foreach (var emp in employees)
            {
                if (emp.Department == 6)
                {
                    Console.WriteLine(emp.Fio);
                }
            }
        }
    }
}
