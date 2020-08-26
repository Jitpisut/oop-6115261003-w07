using System;

namespace oop_6115261003_w07
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jitpisut", "Seephuak", 15000, 20, 30, 10);
            Lecturer l1 = new Lecturer("Jitpisut", "Seephuak", 15000, 5, 10, 20, 20, 30, 20);
            Staff s1 = new Staff("Jitpisut", "Seephuak", 15000, 5, 30, 10, 60);
            Console.WriteLine(l1.ToString());
            Console.WriteLine(s1.ToString());
        }
    }
}
