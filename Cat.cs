using System;
namespace Class_Work
{
    public class Cat : Animal
    {
        public Cat()
        {

        }
        public override string MakeSound()
        {
            return "meaw";
        }
        public override string Move()
        {
            return "Cat is walking";
        }
    }
}
