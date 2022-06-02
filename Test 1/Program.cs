using System;
using System.Collections.Generic;
using static System.Console;

namespace Test1
{
    //Name and StudentCode implement the Information interface method
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
        //Create Name by NameFactory
    public class NameFactory : Factory
    {
        //Create Name
        public override Information CreateStudent() => new Name();
    }

        //Create StudentCode by StudentCodeFactory
    public class StudentCodeFactory : Factory
    {
        //Create StudentCode
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

            foreach (var student in studnetFactorieList)
            {
                student.CreateStudent().Description();
            }
            ReadLine();
        }
    }
}