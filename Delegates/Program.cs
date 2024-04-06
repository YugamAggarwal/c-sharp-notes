//A namespcae is a logical container of types.
// A delegate id degffined inside a namespace. It can also be defined insde a class but that will be called a nested type delgate.
//Delegate: It's a type safe function pointer. The delegate signature match with the function signature. A delegate holds the reference of a method and then calls the method for execution.

/*
class Program
{
    public void AddNums(int a,int b)
    {
        Console.WriteLine(a+b);
    }
    public static string SayHello(string name)
    {
        return "Hello"+ name;
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        p.AddNums(100,50);
        string str = Program.SayHello("Yugam");
        Console.WriteLine(str);
        Console.ReadLine();
    }
}
*/

/*
To call a method by using a delegate we have 3 steps:

1. Define a delegate

[<modifiers>] delegate void|type <Name>([<parameter list>])

public delegate void AddDelegate(int a, int b);
public void AddNums(int a, int b);

The return type ad parameter of delgate should be same as that of the method

public delegate string SayDelegate(string str)
public static string SayHello(string name)

2. Instantiating the delegate

AddDelegate ad = new AddDelegate(p.AddNums);
SayDelegate sd = new SayDelegate(Program.SayHello);

3. Now call the delgate by passing required parameter values, so that internally the method which is bound with the delegate gets executed.
*/
class Program
{
    public delegate string SayDelegate(string str)
    public delegate void AddDelegate(int a, int b);

    public void AddNums(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public static string SayHello(string name)
    {
        return "Hello" + name;
    }
    static void Main(string[] args)
    {
        Program p = new Program();

        AddDelegate ad = new AddDelegate(p.AddNums);
        ad(100, 50);
        ad.Invoke(100, 50);
        SayDelegate sd = new SayDelegate(Program.SayHello);
        string str = sd("Yugam")
        Console.WriteLine(str);

        Console.ReadLine();
    }
}
//Multicast delegates

namespace DegatesProject
{
    public delegate void RectDelegate(double Width, double Height);
    class Reactangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width + Height));
        }
        static void Main()
        {
            Reactangle rect = new Rectangle();

            RectDelegate obj = new RectDelegate(rect.GetArea);
            obj.Invoke(12.34,56.78);

            RectDelegate objk = rect.GetArea;
            objk += rect.GetPerimeter;
            objk.Invoke(12.34,56.78);
            objk.Invoke(47.87,34.89);
            Console.ReadLine();
        }
    }
}
namespace DegatesProject2
{
    public delegate double RectDelegate(double Width, double Height);
    class Reactangle
    {
        public void GetArea(double Width, double Height)
        {
            return Width * Height;
        }
        public void GetPerimeter(double Width, double Height)
        {
            return 2 * (Width + Height);
        }
        static void Main()
        {
            Reactangle rect = new Rectangle();

            RectDelegate obj = new RectDelegate(rect.GetArea);
            double result = obj.Invoke(12.34,56.78); //the latter will override the previious one
            Console.ReadLine();
        }
    }
}
/*
Three Generic Delegates
func     when you are going to have value returning method   
action   when you are going to have a procedure
predicate   when your return tupe is boolean

namespace DelegatesProject 
{
    // public delegate double Delgate1(int x, float y, double z);
    // public delegate void Delegate2(int x, float y, double z);
    // public delegate bool Delegate3(string str);
    class GenericDelegates
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static double AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            // Delegate1 obj1 = AddNums1;
            Func<int, float, double, double> obj1 = AddNums1;
            double result = obj.Invoke(100,34.5f, 193.465);
            Console.WriteLine(result);

            // Delegate2 obj2 = AddNums2;
            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(100,34.5f, 193.465);

            // Delegate3 obj3 = CheckLength;
            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello");
            Console.WriteLine(status);

            Console.ReadLine();
        }
    }
}





