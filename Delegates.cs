using System;
namespace OopsProject
{
    internal delegate void TestDele(string a);
    internal delegate void DelforAnonymousFunc(int a, int b);
    class Delegates
    {
        // internal void Hello()
        // {
        //     Console.WriteLine("Hello Areeb");
        // }
        // internal int Sum(int a, int b)
        // {
        //     return a + b;
        // }

        // internal int Sum(int a, int b)
        // {
        //     return a + b;
        // }
        // internal int Mult(int a, int b)
        // {
        //     return a * b;
        // }

        internal void hello(string a)
        {
            System.Console.WriteLine("Hello " + a);
        }

        public static void Main(string[] args)
        {
            Delegates obj = new Delegates();

            // Create a delegate for Hello()
            // Action consoleAction = obj.Hello;
            // consoleAction();

            // Func for methods that return a value


            // Create a delegate for Sum()
            // Func<int, int, int> mathFunc = obj.Sum;
            // int result = mathFunc(10, 5); // result = 15

            // Console.WriteLine(result);


            // Multicast delegates

            // Mostly use them for void type of functions
            // += to add a delegate
            // -= to remove a delegate

            // Func<int, int, int> sumDele = obj.Sum;
            // int result = sumDele(10, 5);
            // Console.WriteLine(result); // 15

            // sumDele += obj.Mult;
            // int mulRes = sumDele(10, 5);
            // System.Console.WriteLine(mulRes); // 50


            // Traditional way of using delegates
            // Create a delegate after class

            TestDele del = new TestDele(obj.hello);
            // or
            TestDele del1 = obj.hello;

            del("areeb");
            del1("ahmad");

            // Anonymous function
            DelforAnonymousFunc del3 = delegate (int a, int b)
            {
                System.Console.WriteLine(a - b);
            };

            del3(20, 10);


            Func<int, int, int> newDel = (a, b) => a / b;
            System.Console.WriteLine(newDel(10, 5)); 
        }
    }
}