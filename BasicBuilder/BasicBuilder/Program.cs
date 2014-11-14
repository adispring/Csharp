﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicBuilder
{
    class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n Product Builder ---");
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();

    }

    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");    
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override Product GetResult()
        {
            return product;    
        }
    }

    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();
        
        public override void BuildPartA()
        {
            product.Add("Part X");
        }

        public override void BuildPartB()
        {
            product.Add("Part Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.Read(); 

        }
    }
}
