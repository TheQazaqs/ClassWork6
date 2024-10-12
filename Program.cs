using System;
using System.Security.Cryptography.X509Certificates;


namespace Class_Work
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Dog dog2 = new Dog();
            Cat cat2 = new Cat();

            string resDog = dog.MakeSound();
            string resDog2 = dog.Move();
            string resCat = cat.MakeSound();
            string resCat2 = cat.Move();

            Console.WriteLine($"Собака выводит звук: {resDog}; Собака двигается так: {resDog2}; Кошка выводит звук: {resCat}; Кошка двигается так: {resCat2}");
        }
    }
}
