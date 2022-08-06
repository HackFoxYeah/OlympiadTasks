using System;

namespace TrainingClassCreate
{
    class Fuchs
    {
        private int age;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fuchs fox = new Fuchs();
            {
                Console.WriteLine("Введите имя");

                fox.Name = Console.ReadLine();

                Console.WriteLine("Введите возраст");

                fox.Age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Лиса зовут " + fox.Name + " его возраст " + fox.Age);

            Console.ReadKey();
        }
    }
}

