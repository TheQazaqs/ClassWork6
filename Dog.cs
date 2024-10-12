using System;


namespace Class_Work
{
    public class Dog : Animal
    {
        public Dog() 
        {
        
        }
        public override string MakeSound()
        {
            return "Bark";
        }
        public override string Move()
        {
            return "Dog is running";

        }

    }
}
