using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class GameRole
    {
        private int vit;
        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }

        private int atk;
        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }

        private int def;
        public int Defense
        {
            get { return def; }
            set { def = value; }
        }

        public void StateDisplay()
        {
            Console.WriteLine("Role's current State: ");
            Console.WriteLine("Vitality: {0}", this.vit);
            Console.WriteLine("Attatck: {0}", this.atk);
            Console.WriteLine("Defense: {0}", this.def);
            Console.WriteLine("");
        }

        public void GetInitState()
        {
            this.vit = 100;
            this.atk = 100;
            this.def = 100;
        }

        public void Fight()
        {
            this.vit = 0;
            this.atk = 0;
            this.def = 0;
        }

        public RoleStateMemento SaveState()
        {
            return (new RoleStateMemento(vit, atk, def));
        }

        public void RecoveryState(RoleStateMemento memento)
        {
            this.vit = memento.Vitality;
            this.atk = memento.Attack;
            this.def = memento.Defense;
        }
    }

    class RoleStateMemento
    {
        private int vit;
        private int atk;
        private int def;

        public RoleStateMemento(int vit, int atk, int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }

        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }

        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }

        public int Defense
        {
            get { return def; }
            set { def = value; }
        }
    }

    class RoleStateCaretaker
    {
        private RoleStateMemento memento;

        public RoleStateMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }


/**********
 * Memento
 * **********/

    class Originator
    {
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public Memento CreateMemento()
        {
            return (new Memento(state));
        }

        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State =" + state);
        }
    }

    class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string State
        {
            get {return state;}
        }
    }

    class Caretaker
    {
        private Memento memento;

        public Memento Memento
        {
            get{return memento;}
            set{memento = value;}
        }
    }

    /***********
     * Memento
     * **********/

    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            o.Show();

            o.SetMemento(c.Memento);
            o.Show();

            Console.Read();
        }
    }
}
