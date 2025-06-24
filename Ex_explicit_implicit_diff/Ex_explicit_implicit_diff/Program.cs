namespace Ex_explicit_implicit_diff;

class Program
{
    // Implicit interface 
    interface Implicit
    {
        public void Test_Im();
    }

    // Explicit interface 
    interface Explicit
    {
        public void Test_Ex();
    }

    public class Coffe : Implicit
    {
        public void Test_Im() // implicit implementation 
        {
            Console.WriteLine("Coffe");
        }
    }

    public class Water : Explicit
    {
        void Explicit.Test_Ex() // explicit implementation 
        {
            Console.WriteLine("Water");
        }
    }

    // Conflict between interfaces with the same method
    public interface IA
    {
        void Show();
    }

    public interface IB
    {
        void Show();
    }

    public class MyClass : IA, IB
    {
        void IA.Show()
        {
            Console.WriteLine("IA");
        }

        void IB.Show()
        {
            Console.WriteLine("IB");
        }
    }


    static void Main(string[] args)
    {
        // Implicit
        Coffe c1 = new Coffe();
        c1.Test_Im();

        // Explicit
        Water w1 = new Water();
        //w1.Test_Ex();// error
        ((Explicit)w1).Test_Ex(); // Correct

        // Conflicts example
        MyClass m1 = new MyClass();
        IA a = m1;
        IB b = m1;

        a.Show();// method IA
        b.Show();// method IB

        // other way ...
        ((IA)m1).Show();
        ((IB)m1).Show();
    }
}

