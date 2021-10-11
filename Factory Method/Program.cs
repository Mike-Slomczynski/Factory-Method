using System;

namespace Factory_Method
{
    interface IProduct
    {

    }

    class ConcreteProductA : IProduct
    {
    }

    class ConcreteProductB : IProduct
    {
    }

    abstract class Creator
    {
        public abstract IProduct FactoryMethod(string type);
    }

    class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod(string type)
        {
            return type switch
            {
                "A" => new ConcreteProductA(),
                "B" => new ConcreteProductB(),
                _ => throw new ArgumentException("Invalid type", nameof(type)),
            };
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
