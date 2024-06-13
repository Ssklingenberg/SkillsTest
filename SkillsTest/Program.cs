using System;

namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 2");
            Dog dog1 = new Dog(1, "Kiko", "bulldog", 2010);
            Dog dog2 = new Dog(2, "Kiko", "bulldog", 2010);
            Dog dog3 = new Dog(2, "Kiko", "bulldog", 2010);
            Dog dog4 = new Dog(2, "Kiko", "bulldog", 2010);
            Dog dog5 = new Dog(2, "Kiko", "bulldog", 2010);
            Console.WriteLine(dog1);
            Console.WriteLine(dog2);
            Console.WriteLine("opgave 3");
            Member member1 = new Member(101, "Shadia", "SejVej 13, 2660 Brøndby", new DateTime(1989, 7, 20, 0, 0, 0), "42430442", "sk@gmail.com");
            Member member2 = new Member(102, "Shadia", "SejVej 13, 2660 Brøndby", new DateTime(1944, 7, 20, 0, 0, 0), "42430442", "sk@gmail.com");
            Member member3 = new Member(102, "Shadia", "SejVej 13, 2660 Brøndby", new DateTime(1944, 7, 20, 0, 0, 0), "42430442", "sk@gmail.com");
            Member member4 = new Member(102, "Shadia", "SejVej 13, 2660 Brøndby", new DateTime(2015, 7, 20, 0, 0, 0), "42430442", "sk@gmail.com");
            Console.WriteLine(member1);
            Console.WriteLine(member2);
            Console.WriteLine("opgave 4");
            member1.RegisterDog(dog1);
            member1.RegisterDog(dog2);
            member2.RegisterDog(dog3);
            member3.RegisterDog(dog4);
            member4.RegisterDog(dog5);

            //Console.WriteLine(member1);
            //Console.WriteLine(member2);
            member1.PrintDogs();
            member1.RemoveDog(dog1);
            member1.PrintDogs();
            Console.WriteLine("Opgave 6");
            Console.WriteLine(member1.MemberFee(1000));   
            Console.WriteLine(member2.MemberFee(1000));
            Console.WriteLine(member3.MemberFee(1000));
            Console.WriteLine(member4.MemberFee(1000));

            Console.WriteLine("opgave 7");
            Console.WriteLine(member1.Validate);
            Console.WriteLine(member2.Validate);
            Console.WriteLine(member3.Validate);
            Console.WriteLine(member4.Validate);

            Console.WriteLine("opgave 8");
            try
            {
                Console.WriteLine(member1.Validate());
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            try
            {
                Console.WriteLine(member4.Validate());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

