using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Employee
    {
        private double _salary;
        private string _fio;
        private int _departament;
        private int _id = 0;

        static int count;
        public int Id()
        {
            _id++;
            count = _id;
            return count;
        }


        public Employee(string fio, double salary, int departament)
        {
            
            _fio = fio;
            _salary = salary;
            _departament = departament;
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
        public int Departament
        {
            get => _departament;
            set => _departament = value;
        }
    }
}
