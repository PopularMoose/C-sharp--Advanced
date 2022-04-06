using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);


                Person person = new Person(name, age);

                family.AddMember(person);
            }
            Person oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
