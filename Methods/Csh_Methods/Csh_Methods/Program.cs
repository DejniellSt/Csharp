namespace Csh_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text :");
            var in_put = Console.ReadLine();
            var tester = "test123";
            test();
            test1(in_put);
            Console.WriteLine(test2(23, 11));
            Console.WriteLine(test2(test2(1, 3), test2(100, 1)));
            Console.WriteLine(test2(12,11));
            Console.WriteLine(test3(2));
            Console.WriteLine(LowUpper(tester));
            Count(tester);
            //Console.WriteLine(Calculate());
            Calculate();
            Console.ReadLine();
            
        }
        public static void test()
        {
            Console.WriteLine("Void");
        }
        public static void test1(string number)
        {
            Console.WriteLine(number);
        }
        public static int test2(int a,int b)
        {
            return a + b;
        }
        public static string test3(int c)
        {
            var result = c;
            return result.ToString();
        }
        // ex
        public static string LowUpper(string name)
        {
            var result1 = name.ToLower();
            var result2 = name.ToUpper();
            return result1 + result2;
        }

        public static void Count(string input)
        {
            int length = input.Length;
            Console.WriteLine($"The amount of characters is {length}.");
        }

        public static void Calculate()
        {
            Console.WriteLine("Enter the first num :"); 
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second num");
            var num2 = int.Parse(Console.ReadLine());
            var res = num1 + num2;
            Console.WriteLine(res);
           // return res;
        }
    }
}
