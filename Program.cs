namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new ("БВФВЫ", 10000, 1),
                new ("ФВЫФВА", 15000, 1),
                new ("ФВЫАЯС", 20000, 3),
                new ("ЙЦУКЕ", 25000, 2),
                new ("ПАВПА", 35000, 5),
            };

            TaskA();
            TaskB();
            TaskC();
            TaskD();
            TaskE();
            TaskF();

            void TaskA()
            {
                Console.WriteLine("Task A");
                foreach (var emp in employees)
                {
                    
                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Departament}");
                }
            }
            void TaskB()
            {
                Console.WriteLine("Task B");
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на ЗП в месяц: {summa}");
            }
            void TaskC()
            {
                Console.WriteLine("Task C");
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
            void TaskD()
            {
                Console.WriteLine("Task D");
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
            void TaskE()
            {
                Console.WriteLine("Task E");
                int count=0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }
                Console.WriteLine($"Среднее значение ЗП: {summa/count}");
            }
            void TaskF()
            {
                Console.WriteLine("Task F");
                foreach (var emp in employees)
                {
                    Console.WriteLine("ФИО " + emp.Fio);
                }
                Console.ReadKey();
            }
        }
        }
}