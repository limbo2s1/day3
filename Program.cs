namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Employee employee = new Employee("fio", 10000, 1);
            //List<Employee> employees = new List<Employee>()
            //{
            //    new ("Платонов Максим Никитич", 10000, 1),
            //    new ("Киселева Анастасия Александровна", 15000, 1),
            //    new ("Карасев Илья Алексеевич", 20000, 2),
            //    new ("Кузнецова Юлия Артуровна", 25000, 2),
            //    new ("Лапин Егор Сергеевич", 35000, 2),
            //    new ("Кочетова Алиса Тимофеевна", 35000, 3),
            //    new ("Семина Алиса Александровна", 35000, 3),
            //    new ("Филатов Илья Владимирович", 35000, 4),
            //};
            EmployeeBook test = new EmployeeBook();
            List<Employee> testing = new List<Employee>()
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
            test.Day3();
            test.Day4();
            test.Day5();

            //void AllEmployees()
            //{
            //    Console.WriteLine("AllEmployees");
            //    foreach (var emp in employees)
            //    {
                    
            //        Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Departament}");
            //    }
            //}
            //void CostAmountOfMonth()
            //{
            //    Console.WriteLine("CostAmountOfMonth");
            //    double summa = 0;
            //    foreach (var emp in employees)
            //    {
            //        summa += emp.Salary;
            //    }
            //    Console.WriteLine($"Сумма затрат на ЗП в месяц: {summa}");
            //}
            //void MinSalary()
            //{
            //    Console.WriteLine("MinSalary");
            //    double min = 10000000;
            //    foreach (var emp in employees)
            //    {
            //        if (emp.Salary < min)
            //        {
            //            min = emp.Salary;
            //        }
            //    }
            //    Console.WriteLine("Минимальная ЗП " + min);
            //}
            //void MaxSalary()
            //{
            //    Console.WriteLine("MaxSalary");
            //    double max = 0;
            //    foreach (var emp in employees)
            //    {
            //        if (emp.Salary > max)
            //        {
            //            max = emp.Salary;
            //        }
            //    }
            //    Console.WriteLine("Максимальная ЗП " + max);
            //}
            //void AvgSalary()
            //{
            //    Console.WriteLine("AvgSalary");
            //    int count=0;
            //    double summa = 0;
            //    foreach (var emp in employees)
            //    {
            //        count++;
            //        summa += emp.Salary;
            //    }
            //    Console.WriteLine($"Среднее значение ЗП: {summa/count}");
            //}
            //void AllNames()
            //{
            //    Console.WriteLine("AllNames");
            //    foreach (var emp in employees)
            //    {
            //        Console.WriteLine("ФИО " + emp.Fio);
            //    }
                
            //}
            //void IndexingSalary(double percent)
            //{
            //    Console.WriteLine("IndexingSalary");
            //    foreach (var emp in employees)
            //    {
            //        emp.Salary += emp.Salary * percent / 100;
            //        Console.WriteLine("Зарплата проиндексирована: " + emp.Salary);
            //    }
                
            //}
            //void EmployeeMinSalary()
            //{
            //    Console.WriteLine("Выберите отдел(1-5): ");
            //    double chooseDep = Convert.ToInt32(Console.ReadLine());
            //    double min = 999999;
            //    foreach (var emp in employees)
            //    {

            //        if (emp.Salary < min)
            //        {
            //            if (emp.Departament == chooseDep)
            //            {
            //                min = emp.Salary;
            //            }
            //        }
            //    }
            //    Console.WriteLine("Минимальная зарплата: " + min);
            //}

            //void EmployeeMaxSalary()
            //{
            //    Console.WriteLine("Выберите отдел(1-5): ");
            //    double chooseDep = Convert.ToInt32(Console.ReadLine());
            //    double max = 0;
            //    foreach (var emp in employees)
            //    {

            //        if (emp.Salary > max)
            //        {
            //            if (emp.Departament == chooseDep)
            //            {
            //                max = emp.Salary;
            //            }
            //        }
            //    }
            //    Console.WriteLine("Максимальная зарплата: " + max);
            //}

            //void MidSalary()
            //{
            //    Console.WriteLine("Выберите отдел(1-5): ");
            //    double chooseDep = Convert.ToInt32(Console.ReadLine());
            //    int count = 0;
            //    double summa = 0;
            //    foreach (var emp in employees)
            //    {
            //        if (chooseDep == emp.Departament)
            //        {
            //            count++;
            //            summa += emp.Salary;
            //        }
            //    }
            //    Console.WriteLine($"Среднее значение ЗП: {summa / count}");
            //}

            //void IndexSalaryPoOtdelu()
            //{
            //    Console.WriteLine("Выберите отдел(1-5): ");
            //    double chooseDep = Convert.ToInt32(Console.ReadLine());
            //    double index = 1.2;
            //    foreach (var emp in employees)
            //    {
            //        if (chooseDep == emp.Departament)
            //        {
            //            Console.WriteLine($"Зарплата увеличена на 20%: {emp.Salary * index}");
            //        }
            //    }
            //}

            //void DanniePoOtdelu()
            //{
            //    Console.WriteLine("Выберите отдел(1-5): ");
            //    double chooseDep = Convert.ToInt32(Console.ReadLine());
            //    foreach (var emp in employees)
            //    {
            //        if (chooseDep == emp.Departament)
            //        {
            //            Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
            //        }
            //    }
            //}
            Console.ReadKey();
        }
    }
}