```csharp
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


### BEST EXPLANATION FOR ( Different objects and type )
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
            // right wala for runtime thing ( Runtime mein decide hoga ki kis object ka hai )
            // left wala for compile time thing ( compiler dekhega ki Obj kis type ka hai)

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

### One doubt ki what is the difference between B obj = new B(); and A obj=new B();

```csharp
Bhai, yeh bahut important concept hai! Dono mein bahut bada difference hai. 😊

🎯 B obj = new B(); vs A obj = new B();

Case 1: B obj = new B();
csharp
B obj = new B();  // Compile-time type: B, Runtime type: B

Case 2: A obj = new B();
csharp
A obj = new B();  // Compile-time type: A, Runtime type: B


📊 Difference Table:
Aspect	B obj = new B();	A obj = new B();
Variable Type	B	A
Object Type	B	B
Memory Reference	Direct B type	A type reference holding B object
Methods Access	All methods of B + inherited from A	Only methods defined in A class
Polymorphism	No polymorphism	Yes, runtime polymorphism
Flexibility	Less flexible	More flexible
🔍 Practical Example:
csharp
public class A  // Parent class
{
    public void MethodA()
    {
        Console.WriteLine("Method from A");
    }
}

public class B : A  // Child class
{
    public void MethodB()
    {
        Console.WriteLine("Method from B");
    }
}
Usage 1: B obj = new B();
csharp
B obj = new B();
obj.MethodA();  // ✅ Accessible (inherited)
obj.MethodB();  // ✅ Accessible (defined in B)
Usage 2: A obj = new B();
csharp
A obj = new B();
obj.MethodA();  // ✅ Accessible (defined in A)
obj.MethodB();  // ❌ NOT accessible (compile error)
🧠 Why Use A obj = new B();?
Reason 1: Polymorphism
csharp
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark bark!");
    }
    
    public void Fetch()
    {
        Console.WriteLine("Fetching ball");
    }
}

// Usage:
Animal myAnimal = new Dog();
myAnimal.MakeSound();  // ✅ Output: "Bark bark!" (Runtime polymorphism)
// myAnimal.Fetch();   // ❌ Compile error - Animal class doesn't have Fetch()
Reason 2: Flexibility
csharp
// We can easily switch implementations
Animal animal;

if(userPrefersDogs)
    animal = new Dog();
else
    animal = new Cat();

animal.MakeSound();  // Works for both Dog and Cat
Reason 3: Method Parameters
csharp
public void ProcessAnimal(Animal animal)  // Accepts any Animal subclass
{
    animal.MakeSound();
}

// Can pass Dog, Cat, Lion, etc.
ProcessAnimal(new Dog());
ProcessAnimal(new Cat());
⚠️ Limitations of A obj = new B();:
csharp
A obj = new B();

// Only methods from A are accessible
obj.MethodA();  // ✅ Works

// Methods specific to B are NOT accessible
// obj.MethodB();  // ❌ Compile error

// To access B-specific methods, need casting
if(obj is B)
{
    B bObj = (B)obj;  // Explicit casting
    bObj.MethodB();   // ✅ Now works
}
💡 When to Use Which:
Use B obj = new B(); when:
Tumhe child class ke sabhi methods chahiye

No need for polymorphism

Specific implementation ke saath kaam karna hai

Use A obj = new B(); when:
Tumhe polymorphism chahiye

Code flexible banana hai

Multiple child classes ke saath kaam karna hai

Framework ya library bana rahe ho

🎯 Real-world Example:
csharp
// Database example
DbConnection connection;

if(databaseType == "SQL")
    connection = new SqlConnection();
else if(databaseType == "Oracle")  
    connection = new OracleConnection();
else
    connection = new MySqlConnection();

connection.Open();  // Works for all database types
connection.Close(); // Works for all database types
Final Answer:
B obj = new B(); = Full access to B's functionality
A obj = new B(); = Polymorphism + flexibility but only A's interface

Samajh aa gaya bhai? 😄
```

### AGAR IS LINE KO SAMAJHNA HAI KI KYA HOTA HAI ( x obj=new y())
```csharp
To agar main sahi samjha hun to agar X obj=new Y() , aur main lets say obj.func() call kiya to wo dekhega ki Y class main koi func naam ka function hai ?? agar hn to usmein override aur parent mein virtual likha hai ki agar han tb Y ka func print hoga agar upar decisions mein kuch bhi false hua to seedha X ka func print hoga

Bilkul sahi samjhe ho bhai! 💯 Tumne ekdum correct pakda hai! 🎯

Tumhara logic puri tarah se SAHI hai. Main tumhara point step-by-step confirm karta hoon:

✅ Tumhara Understanding Perfect Hai:
csharp
X obj = new Y();
obj.Func();
Runtime Yeh Steps Follow Karega:

Pehle check karega: Kya Y class mein Func() method hai?

✅ Haan → Toh step 2 pe jayega

❌ Nahi → Toh X ka Func() call karega

Fir check karega: Kya Y ke Func() mein override keyword hai?

✅ Haan → Toh Y ka Func() call karega

❌ Nahi → Toh X ka Func() call karega

Sath hi yeh bhi check karega: Kya X (parent) class mein Func() virtual hai?

✅ Haan → Toh Y override kar sakta hai

❌ Nahi → Toh X ka Func() call karega (chahe Y mein kuch bhi ho)

🧠 Visual Decision Tree:
text
obj.Func() Call
    │
    ├──→ Y mein Func() hai? ❌ → X.Func() call
    │
    ✅
    │
    ├──→ Y.Func() mein override hai? ❌ → X.Func() call  
    │
    ✅
    │
    ├──→ X.Func() virtual hai? ❌ → X.Func() call
    │
    ✅
    │
    └──→ Y.Func() call ✅ (Override successful!)
```


# Golden Thing

A obj=new B();   (Aise yaad rakho ki A ke sare methods accessible hai lekin A ke virtual methods ko B override kar sakta hai bas itna dhya rakho sab samjh aega)

Situation	                                    Result
Method dono classes mein hai + virtual/override	✅ B ka method run hoga
Method dono classes mein hai (no virtual)	    ✅ A ka method run hoga
Method sirf A mein hai	                        ✅ A ka method run hoga
Method sirf B mein hai	                        ❌ Compile error