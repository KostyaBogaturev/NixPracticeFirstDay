using System;

namespace Library
{
    public class User
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public User(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public User()
        {

        }

        public double GetSalary(double salaryPerHour, int workTime) => salaryPerHour * workTime;
    }
}
