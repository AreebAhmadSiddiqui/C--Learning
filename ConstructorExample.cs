// using System;

// namespace OopsProject
// {
//     class ConstructorExample
//     {
//         int a;
//         static ConstructorExample()
//         {
//             Console.WriteLine("Static Constructor");
//         }

//         internal ConstructorExample()
//         {
//             Console.WriteLine("Non Static Constructor");
//         }

//         internal ConstructorExample(int a)
//         {
//             Console.WriteLine("Parameterized Constructor");
//         }

//         internal ConstructorExample(ConstructorExample obj)
//         {
//             this.a = obj.a;
//             Console.WriteLine("Hi I am copy constructor");
//         }


//         // static void Main()
//         // {

//         //     // ConstructorExample obj = new ConstructorExample();
//         //     // without the above line prints Static Constructor

//         //     // ConstructorExample obj = new ConstructorExample();
//         //     // with the above line prints ( 
//         //     // Static Constructor
//         //     // Non Static Constructor )

//         //     ConstructorExample obj2 = new ConstructorExample(23);
//         //     // with the above line prints

//         //     // Static Constructor
//         //     // Parameterized Constructor


//         //     // Copy constructor

//         //     ConstructorExample obj3 = new ConstructorExample(obj2);
//         // }
//     }
// }