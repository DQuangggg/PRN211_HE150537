using System;
using System.Collections.Generic;
using static System.Console;

namespace Test1
{
    public interface Information
    {
        void Description();
    }
    public class Name : Information
    {
        public void Description() => WriteLine("My name is Nguyen Dang Quang");

    }
    public class StudenCode : Information
    {
        public void Description() => WriteLine("My student code is HE150537");

    }
  
    public abstract class Factory
    {
        public abstract Information CreateStudent();
    }
    public class NameFactory : Factory
    {

        public override Information CreateStudent() => new Name();
    }

    public class StudentCodeFactory : Factory
    {
        public override Information CreateStudent() => new StudenCode();

    }
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("***Factory Method Pattern ***\n");
            List<Factory> studnetFactorieList = new List<Factory>
            {
                new NameFactory(),
                new StudentCodeFactory()
            };

            foreach (var animal in studnetFactorieList)
            {
                animal.CreateStudent().Description();
            }
            ReadLine();
        }
    }
}