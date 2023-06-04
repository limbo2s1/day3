using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class EmployeeBook
    {
        Employee employee = new Employee("fio", 10000, 1);
        private List<Employee> employees = new List<Employee>()
            {
                new ("Платонов Максим Никитич", 10000, 1),
                new ("Киселева Анастасия Александровна", 15000, 1),
                new ("Карасев Илья Алексеевич", 20000, 2),
                new ("Кузнецова Юлия Артуровна", 25000, 2),
                new ("Лапин Егор Сергеевич", 35000, 2),
                new ("Кочетова Алиса Тимофеевна", 35000, 3),
                new ("Семина Алиса Александровна", 35000, 3),
                new ("Филатов Илья Владимирович", 35000, 4),
            };
        public void Day3()
        {
            void AllEmployees()
            {
                Console.WriteLine("AllEmployees");
                foreach (var emp in employees)
                {

                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Departament}");
                }
            }
            void CostAmountOfMonth()
            {
                Console.WriteLine("CostAmountOfMonth");
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на ЗП в месяц: {summa}");
            }
            void MinSalary()
            {
                Console.WriteLine("MinSalary");
                double min = 10000000;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
                Console.WriteLine("Минимальная ЗП " + min);
            }
            void MaxSalary()
            {
                Console.WriteLine("MaxSalary");
                double max = 0;
                foreach (var emp in employees)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                    }
                }
                Console.WriteLine("Максимальная ЗП " + max);
            }
            void AvgSalary()
            {
                Console.WriteLine("AvgSalary");
                int count = 0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }
                Console.WriteLine($"Среднее значение ЗП: {summa / count}");
            }
            void AllNames()
            {
                Console.WriteLine("AllNames");
                foreach (var emp in employees)
                {
                    Console.WriteLine("ФИО " + emp.Fio);
                }

            }
            void IndexingSalary(double percent)
            {
                Console.WriteLine("IndexingSalary");
                foreach (var emp in employees)
                {
                    emp.Salary += emp.Salary * percent / 100;
                    Console.WriteLine("Зарплата проиндексирована: " + emp.Salary);
                }

            }
            AllEmployees();
            CostAmountOfMonth();
            MinSalary();
            MaxSalary();
            AvgSalary();
            AllNames();
            IndexingSalary(10);
        }
        public void Day4()
        {
            void EmployeeMinSalary()
            {
                Console.WriteLine("Выберите отдел(1-5): ");
                double chooseDep = Convert.ToInt32(Console.ReadLine());
                double min = 999999;
                foreach (var emp in employees)
                {

                    if (emp.Salary < min)
                    {
                        if (emp.Departament == chooseDep)
                        {
                            min = emp.Salary;
                        }
                    }
                }
                Console.WriteLine("Минимальная зарплата: " + min);
            }

            void EmployeeMaxSalary()
            {
                Console.WriteLine("Выберите отдел(1-5): ");
                double chooseDep = Convert.ToInt32(Console.ReadLine());
                double max = 0;
                foreach (var emp in employees)
                {

                    if (emp.Salary > max)
                    {
                        if (emp.Departament == chooseDep)
                        {
                            max = emp.Salary;
                        }
                    }
                }
                Console.WriteLine("Максимальная зарплата: " + max);
            }

            void MidSalary()
            {
                Console.WriteLine("Выберите отдел(1-5): ");
                double chooseDep = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    if (chooseDep == emp.Departament)
                    {
                        count++;
                        summa += emp.Salary;
                    }
                }
                Console.WriteLine($"Среднее значение ЗП: {summa / count}");
            }

            void IndexSalaryPoOtdelu()
            {
                Console.WriteLine("Выберите отдел(1-5): ");
                double chooseDep = Convert.ToInt32(Console.ReadLine());
                double index = 1.2;
                foreach (var emp in employees)
                {
                    if (chooseDep == emp.Departament)
                    {
                        Console.WriteLine($"Зарплата увеличена на 20%: {emp.Salary * index}");
                    }
                }
            }

            void DanniePoOtdelu()
            {
                Console.WriteLine("Выберите отдел(1-5): ");
                double chooseDep = Convert.ToInt32(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (chooseDep == emp.Departament)
                    {
                        Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                    }
                }
            }
            EmployeeMinSalary();
            EmployeeMaxSalary();
            MidSalary();
            DanniePoOtdelu();
            IndexSalaryPoOtdelu();
        }
        public void Day5()
        {
            void AddPeople()
            {
                Console.WriteLine("Введите ФИО: ");
                string Fio = Console.ReadLine();
                Console.WriteLine("Введите Зарплату: ");
                double Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите отдел: ");
                int Departament = Convert.ToInt32(Console.ReadLine());
                Employee employee = new Employee(Fio, Salary, Departament);
                employees.Add(employee);
                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.Fio} {emp.Salary} {emp.Departament}");
                }
                Console.ReadLine();
            }
            void DeletePeople()
            {
                Console.WriteLine("Введите id: ");
                int id = 0;
                id = Convert.ToInt32(Console.ReadLine());
                employees.RemoveAt(id - 1);
                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.Fio} {emp.Salary} {emp.Departament}");
                }
                Console.ReadLine();
            }
            void ChangePeople()
            {
                Console.WriteLine("Введите ФИО: ");
                string Fio = Console.ReadLine();
                Console.WriteLine("Введите Зарплату: ");
                double Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите № отдела: ");
                int Otdel = Convert.ToInt32(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Fio == Fio)
                    {
                        emp.Departament = Otdel;
                        emp.Salary = Salary;
                    }
                    Console.WriteLine($"{emp.Fio} {emp.Salary} {emp.Departament}");
                }
                Console.ReadLine();
            }
            void FioPoOtdelam()
            {
                Console.WriteLine("День 5 задание 4");
                string FirstFio = "";
                string SecondFio = "";
                string ThirdFio = "";
                string FourthFio = "";
                string FifthFio = "";
                foreach (var emp in employees)
                {

                    if (emp.Departament == 1)
                    {
                        FirstFio += emp.Fio + "\n";
                    }
                    if (emp.Departament == 2)
                    {
                        SecondFio += emp.Fio + "\n";
                    }
                    if (emp.Departament == 3)
                    {
                        ThirdFio += emp.Fio + "\n";
                    }
                    if (emp.Departament == 4)
                    {
                        FourthFio += emp.Fio + "\n";
                    }
                    if (emp.Departament == 5)
                    {
                        FifthFio += emp.Fio + "\n";
                    }
                }
                Console.WriteLine($"Отдел #1: " + "\n" + FirstFio);
                Console.WriteLine("Отдел #2: " + "\n" + SecondFio);
                Console.WriteLine("Отдел #3: " + "\n" + ThirdFio);
                Console.WriteLine("Отдел #4: " + "\n" + FourthFio);
                Console.WriteLine("Отдел #5: " + "\n" + FifthFio);
                Console.ReadLine();
            }
            AddPeople();
            DeletePeople();
            ChangePeople();
            FioPoOtdelam();
        }
    }
}
