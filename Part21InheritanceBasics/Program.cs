using System;

namespace Part21InheritanceBasics
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Contructore Called"); ;
        }
        public ParentClass(string s)
        {
            Console.WriteLine("String is={0} ", s);

        }
    }
    class Child :ParentClass
    {
        public Child():base("Shubham")
        {
            Console.WriteLine("Child Class Constructor Called");

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
        
            Child c = new Child();
            
        }
    }
}
