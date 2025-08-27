# OOPS

-> Object Oriented Programming system
=> Security , code reusability and code usability
-> two parts ( class and objects)
-> class is the blueprint of the objects 
-> objects are the entity of a class

```C#
class Classname{
    private datatype variablename;
    internal returntype Methodname(){
        code block..
    }
}

class MainClass{
    static void Main(){
        ClassName ref= new ClassName();
        ref.MethodName();
    }
}
```

-> Four Pillars
a) Data Encapsulation -> code seuritr
b) Data Abstraction -> Layer security
c) Polymorphism -> Overloading and Overriding
d) Inheritence -> Code Resualibility


Element Type	                Default Access Modifier
Classes	                        internal
Class members (fields, methods)	private
Namespaces	                    public (always accessible)
Enum members	                public (always accessible)



-> Static members will be called by class name
-> Use static for shared variables or methods


Type of member function

-> static -> this member function is used to define static data member and it will be called by ClassName

class Classname{
    static void MethodName(){
        static content
    }
}

Classname.MethodName();

-> non static ->  called by obj

class Classname{
    void MethodName(){
         content
    }
}

Classname obj=new Classname();
obj.MethodName();

### Constructor

It is a default component of the class that will be called automatically when we create an object

a) System constructor ( default )
b) User-defined constructor ()

 i) static contructor: this type of constructor will be called without object and it is used to initalize static data member of class
 ii) non - static constructor : this type of constructor will be called by object and it is used to initialize dynamic data member of class


 Note : static constructor is always called after main only it runs
 -> other than that when u create object it will be called


Copy Constructor : used to copy the reference of one object to another

class A{
    int a;
    A(){
        a=10;
    }
    A(A obj){
        this.a=obj.a;
        this.b=obj.b;
    }
}

-----------------------------------------------------

Property : it is used to provide getter and setter method to read and write the data member value.
it is basically used to provide data encapsulation to access data member indirectly

private int variable

// short hand
public int Variable{
    get; set;
}

-----------------------------------------------------

Data Encapsulation

- Hiding the internal data member of class and access it using method or properties.

we will create private data member to implement data encapsulation

class A{
    private int a;
}

a is the private data member it can be access using method block or property , directly you cannot access it

-----------------------------------------------------

Data Abstraction

- the act of representing essential features of a code only and hiding the non needed part of the code from the user is called data abstraction

- We use abstract and interface to implement data abstraction

-----------------------------------------------------

Polymorphism: Poly means many and morphous means form , using this we can create same name method with multiple form

1) Static Polymorphism
   Function or method overloading is the example of static polymorphism, using this we will create same name method with different pparameters

   Constructor is the best example of this type of polymorphism

   - Saves memory as ek hi memory banti hai ek function ki


2) Dynamic Polymorphism

it provides overriding and over hiding features, in case of overrriding, we will create same name method from base to derived class to change functionality

class Parent{
    void funct(){

    }
}

class Child:Parent{
    void funct(){

    }
}

Jab bhi derive hoga parent child mein to same function dhoondega in parent fir use override kardega so we use

class Parent{
    virtual void funct(){

    }
}

class Child:Parent{
    override void funct(){

    }
}

```C#
🎯 Method Overriding Kya Hai?
Method Overriding ek aisa process hai jisme:

Parent class ke method ko Child class mein redefine kiya jata hai

Child class parent ke method ko replace kar deti hai apne version se

📝 Kaise Karte Hain?
Step 1: Parent Class Mein virtual Keyword Lagao
csharp
public class Animal  // Parent class
{
    public virtual void MakeSound()  // virtual = "override kar sakte ho"
    {
        Console.WriteLine("Animal makes a sound");
    }
}
Step 2: Child Class Mein override Keyword Lagao
csharp
public class Dog : Animal  // Child class
{
    public override void MakeSound()  // override = "parent ka method change kar raha hoon"
    {
        Console.WriteLine("Dog barks: Woof woof!");
    }
}
🧪 Practical Example
csharp
// Parent class
public class BankAccount
{
    public double Balance { get; protected set; }
    
    // Virtual method - child classes ise change kar sakti hain
    public virtual void CalculateInterest()
    {
        Console.WriteLine("General interest calculation");
    }
}

// Child class 1
public class SavingsAccount : BankAccount
{
    public override void CalculateInterest()  // Parent ke method ko override kiya
    {
        Balance += Balance * 0.04;  // 4% interest
        Console.WriteLine("Savings account interest added: 4%");
    }
}

// Child class 2  
public class FixedDeposit : BankAccount
{
    public override void CalculateInterest()  // Same method different implementation
    {
        Balance += Balance * 0.08;  // 8% interest
        Console.WriteLine("FD interest added: 8%");
    }
}
🔍 Kaam Kaise Karta Hai?
csharp
BankAccount account1 = new SavingsAccount();
account1.CalculateInterest();  // Output: "Savings account interest added: 4%"

BankAccount account2 = new FixedDeposit();  
account2.CalculateInterest();  // Output: "FD interest added: 8%"

BankAccount account3 = new BankAccount();
account3.CalculateInterest();  // Output: "General interest calculation"
⚠️ Important Rules
Method Signature Same honi chahiye:

Same name, same return type, same parameters

Access Level Badal Nahi Sakte:

Parent public hai toh child bhi public hi rahega

virtual aur override dono necessary hain

🆚 Overriding vs Overloading
Overriding	Overloading
Same method, different implementation	Different methods, same name
Inheritance required	Inheritance not required
Runtime decision	Compile time decision
virtual + override keywords	Different parameters



Sabse bada confusion 

public class Animal  // Parent class
{
    public virtual void MakeSound()  // virtual = "override kar sakte ho"
    {
        Console.WriteLine("Animal makes a sound");
    }
}
Step 2: Child Class Mein override Keyword Lagao
csharp
public class Dog : Animal  // Child class
{
    public override void MakeSound()  // override = "parent ka method change kar raha hoon"
    {
        Console.WriteLine("Dog barks: Woof woof!");
    }
}

Ye line hai:
Animal myDog = new Dog();
myDog.MakeSound();

Step 1: Variable Declaration (Left Side)

Animal myDog
Animal - Yeh variable ka type hai (compile-time type)

myDog - Yeh variable ka name hai

Matlab: Hum ek aisa variable bana rahe hai jo sirf Animal type ke objects store kar sakta hai

Step 2: Object Creation (Right Side)
csharp
new Dog();
new - Memory mein naya object create karo

Dog() - Dog class ka constructor call karo

Matlab: Actually mein hum Dog class ka object create kar rahe hai

Step 3: Assignment (=)
csharp
Animal myDog = new Dog();
Right side ka object (Dog) left side ke variable (Animal) mein assign ho raha hai

Yeh possible hai kyunki Dog class Animal class se inherit karti hai (IS-A relationship)

Step 4: Method Call
csharp
myDog.MakeSound();
Yahan magic hoti hai! 🎩

Compiler variable ka type dekhta hai (Animal)

Lekin Runtime actual object ka type check karta hai (Dog)

🧠 Runtime Decision:
Kya Animal class mein MakeSound() method virtual hai? → Haan

Kya Dog class ne MakeSound() method ko override kiya hai? → Haan

Toh Runtime Dog class ka MakeSound() method call karega

📊 Visual Representation:
text
Variable: Animal myDog (Compile-time type)
  |
  |-- Actually points to → Object: new Dog() (Runtime type)
        |
        |-- Makesound() method: "Dog barks: Woof woof!" 🐕
❓ Common Confusion:
Q: Variable Animal type ka hai, toh Animal ka method kyun nahi call hua?
A: Kyunki method virtual aur override hai, isliye Runtime actual object (Dog) ke hisaab se decision leta hai

💡 Real-life Example:
Socho tumhare paas ek "Vehicle" ka license hai

But tum actually mein "Car" chalate ho

Jab tum horn bajate ho, toh "Car" ka horn bajega, na ki general "Vehicle" ka horn

Final Output:

text
"Dog barks: Woof woof!"
```

### Agar override or virtual mein kuch na likhein to?

Situation	                            Result	                      Kyu?
Parent: virtual + Child: override	    Child method call hoga ✅	Runtime actual object check karta hai
Parent: virtual + Child: NO override	Parent method call hoga ❌	Child ne naya method banaya hai
Parent: NO virtual + Child: kuch bhi	Parent method call hoga ❌	Parent ne permission hi nahi di

Final Baat: Agar tum chahte ho ki child class ka method call ho, toh virtual + override dono zaroori hai! 🎯
----------------------------------------------------------------------------------------------------------

Inheritence 

Code reusability 

Types of inheritence

a) Single
b) Multilevel
c) Hierarchical

For Constructor use ChildConstructor( ) : base(parms for Parent constructor)

Abstract Class and Methods

-> Pure Blueprint hoti hai
-> Methods sirf likhte hai implement ni karte

```C#

Abstract Classes Kya Hain?
Abstract classes aisi classes hain jo:

Incomplete hoti hain (pure blueprints)

Directly instantiate nahi ki ja sakti (object nahi bana sakte)

Inheritance ke liye design ki gayi hain

📝 Abstract Methods Kya Hain?
Abstract methods aise methods hain jo:

Sirf declaration hote hain, no implementation

Child classes must unko implement karein

Sirf abstract classes mein hi ho sakte hain


🔧 Basic Syntax
Abstract Class Banane ka Tarika:
csharp
public abstract class Shape  // abstract keyword lagana hai
{
    // Abstract method - no body, just signature
    public abstract double CalculateArea();
    
    // Regular method with implementation
    public void Display()
    {
        Console.WriteLine("This is a shape");
    }
    
    // Virtual method (can be overridden)
    public virtual void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
}
Child Class Banane ka Tarika:
csharp
public class Circle : Shape  // Inherit from abstract class
{
    public double Radius { get; set; }
    
    // MUST implement abstract method
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    
    // Optional: override virtual method
    public override void Draw()
    {
        Console.WriteLine("Drawing circle");
    }
}
💡 Real-world Examples
Example 1: Payment System
csharp
public abstract class Payment
{
    public double Amount { get; set; }
    
    // Abstract method - har child ko implement karna hoga
    public abstract void ProcessPayment();
    
    // Common functionality sab payments ke liye
    public void GenerateReceipt()
    {
        Console.WriteLine($"Receipt for ₹{Amount} generated");
    }
}

public class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }
    
    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing credit card payment: ₹{Amount}");
        // Credit card specific logic
    }
}

public class UPIPayment : Payment
{
    public string UPIId { get; set; }
    
    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing UPI payment: ₹{Amount}");
        // UPI specific logic
    }
}

// Usage:
Payment payment1 = new CreditCardPayment { Amount = 1000 };
payment1.ProcessPayment();  // Credit card processing
payment1.GenerateReceipt(); // Common functionality

Payment payment2 = new UPIPayment { Amount = 500 };
payment2.ProcessPayment();  // UPI processing
payment2.GenerateReceipt(); // Common functionality


Important Rules aur Restrictions
1. Instantiation nahi kar sakte:
csharp
// ❌ COMPILE ERROR:
// Shape shape = new Shape(); 

// ✅ SAHI TARIKA:
Shape shape = new Circle();  // Through child class
2. Abstract methods ki properties:
Sirf abstract classes mein hi ho sakte hain

Public, protected, ya internal ho sakte hain

Private nahi ho sakte

Static nahi ho sakte

3. Abstract class mein ye sab ho sakta hai:
Fields (variables)

Regular methods (with implementation)

Virtual methods

Properties

Constructors

Events
```


### Virtual vs Abstract Method

Virtual Method	Abstract Method
public virtual void Method()	public abstract void Method()
Body required ✅	No body ❌
override in child	override in child
Optional to override	Must override ✅


```


### BEST EXPLANATION
```C#
using System;

namespace OopsProject
{
    class A{}
    class B : A{ }

    class Program
    {
        static void Main(string[] args)
        {
            // right to left padho
            B obj = new B();  // aise padho ( B is A B ) yes
            A obj2 = new A(); // A is a A yes
            A obj3 = new B(); // B is a A yes
            B obj4 = new A(); // A is a B ni

            Animal obj = new Animal(); // Kya animal is a animal hai haan hai
            Dog obj = new Dog(); // kya dog is a dog hai haan hai
            Animal obj = new Dog(); // kya dog is a animal hai haan hai ( due to inheritance)
            Dog obj = new Animal(); // kya animal dog hai ( ni )
        }
    }
}
```

### Interfacess

```csharp
🎯 Interface Kya Hai?
Interface ek contract ya agreement hai jo batata hai ki:

"Agar tum mere interface ko implement karte ho, toh tumhe yeh methods zaroor provide karne honge"

Pure blueprint hota hai - koi implementation nahi hoti

📝 Basic Syntax:
csharp
// Interface definition
public interface IAnimal
{
    void MakeSound();  // No body, just signature
    void Eat();        // No body, just signature
}

// Class implementing interface
public class Dog : IAnimal  // Implement kiya interface
{
    public void MakeSound()  // Method implement kiya
    {
        Console.WriteLine("Bark bark!");
    }
    
    public void Eat()        // Method implement kiya
    {
        Console.WriteLine("Eating dog food");
    }
}


🔍 Interface vs Abstract Class:
Interface	Abstract Class
Only method signatures	Partial implementation ho sakta hai
Multiple inheritance ✅	Single inheritance ❌
No fields/variables	Fields/variables ho sakte hain
No constructors	Constructors ho sakte hain
All methods public	Access modifiers use kar sakte hain

public interface IPayment
{
    void ProcessPayment(double amount);
    bool IsPaymentSuccessful();
}

public class CreditCardPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment: ₹{amount}");
    }
    
    public bool IsPaymentSuccessful()
    {
        return true;
    }
}

public class UPIPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing UPI payment: ₹{amount}");
    }
    
    public bool IsPaymentSuccessful()
    {
        return true;
    }
}


 Advanced Features:
1. Multiple Interfaces:
csharp
public interface IFlyable
{
    void Fly();
}

public interface ISwimmable
{
    void Swim();
}

public class Duck : IFlyable, ISwimmable  // Multiple interfaces
{
    public void Fly()
    {
        Console.WriteLine("Duck flying");
    }
    
    public void Swim()
    {
        Console.WriteLine("Duck swimming");
    }
}
2. Interface Inheritance:
csharp
public interface IAnimal
{
    void Eat();
}

public interface IMammal : IAnimal  // Interface inherit kar raha hai
{
    void Run();
}

public class Dog : IMammal
{
    public void Eat()  // IAnimal method
    {
        Console.WriteLine("Eating");
    }
    
    public void Run()  // IMammal method
    {
        Console.WriteLine("Running");
    }
}
```

### Enums

- readonly values
- Convert using int to get the index


### Files

using System;
using System.IO;

namespace OopsProject
{

    class Program
    {

        static void Main(string[] args)
        {
           

            // File likhna (Write)
            string filePath = @".\files\data.txt";

            // 1. File mein likhna
            File.WriteAllText(filePath, "Hello World!\nThis is second line.");

            // 2. File se padhna (Read)
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            // 3. File mein append karna (existing content ke end mein add karna)
            File.AppendAllText(filePath, "\nThis is appended text.");

            // 4. Check karna file exists hai ya nahi
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists!");
            }

            content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            // 5. File delete karna
            // File.Delete(filePath);
        }
    }
}

### Exception Handling

try - catch - finally ki kahani