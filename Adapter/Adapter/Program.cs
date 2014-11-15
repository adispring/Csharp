using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Common Request!");
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specificial Request!");
        }
    }

    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }

    class Forwards : Player
    {
        public Forwards(string name)
            : base(name)
        { }

        public override void Attack()
        {
            Console.WriteLine("Forwards {0} Attack",name);
        }

        public override void Defense()
        {
            Console.WriteLine("Forwards {0} Defense", name);
        }
    }

    class Center : Player
    {
        public Center(string name)
            : base(name)
        { }

        public override void Attack()
        {
            Console.WriteLine("Center {0} Attack", name);
        }

        public override void Defense()
        {
            Console.WriteLine("Center {0} Defense", name);
        }
    }

    class Guards : Player
    {
        public Guards(string name)
            : base(name)
        { }

        public override void Attack()
        {
            Console.WriteLine("Guards {0} Attack", name);
        }

        public override void Defense()
        {
            Console.WriteLine("Guards {0} Defense", name);
        }
    }

    class ForeignCenter
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void 进攻()
        {
            Console.WriteLine("外籍中锋 {0} 进攻", name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋 {0} 防守", name);
        }
    }

    class Translator : Player 
    {
        private ForeignCenter wjzf = new ForeignCenter();

        public Translator(string name)
            : base(name)
        {
            wjzf.Name = name;
        }

        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwards("Newton");
            b.Attack();

            Player o = new Guards("Obama");
            o.Defense();

            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();

            Console.Read();

        }
    }
}
