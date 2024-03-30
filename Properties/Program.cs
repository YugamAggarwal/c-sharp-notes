
/*
//By default acces of attributes(Radius) of entities( Circles) is private. That means its memory will be allocated when the object is created but you won't be able to access it  or modify it.

public class Circle
{
    double Radius = 12.34;
}

*/

/*
//One way is to declare the variable pulic but this way you will loose control. Anyone will be able to get that vaue and anyone will be able to set the value. 

public class Circle
{
    public double Radius = 12.34;
}

public class TestCircle
{
    static void Main()
    {
        Circle c = new Circle();
        double radius = c.Radius; 
        c.Radius = 56.78;

    }
}

*/
/*
public class Circle
{
    double Radius = 12.34;
    public double GetRadius() //Provides only get acces to the value
    {
        return Radius;
    }
    public void SetRadius(double value) // Provides only set acces to the value
    {
        Radius = value;
    }
    //Omitting anyone can restrict a feature so you will have control
}
public class TestCircle
{
    static void Main()
    {
        Circle c = new Circle();
        double radius = c.GetRadius();
        c.SetRadius(56.78);

    }
}
*/

/*
// A property is a group of methods combined so that we will onl left with single name rather than two name for get and set, No need to declare parametry it is implicityly declared.

[<modifiers>] <type> <Name>
{
    [ get {<stmts>}]    //Get Accessor
    [ set {<stmts>}]    //Set Accessor
}


public class Circle
{
    double Radius = 12.34;
    public double RadiusProperty
    {
        get {return Radius;} // Omit this to revoke the get access. Represetns a value returinign method without parameter
        set {Radius = value;} //Represents a non value returning method with parameter
    }
    
}

public class TestCircle
{
    static void Main()
    {
        Circle c = new Circle();
        double radius = c.RadiusProperty;
        c.RadiusProperty = 56.78;
    }
}
*/

// if there are 100 fields, it is not feasible to define property like this
/*
// if you are declaring a property for a field follow the convention of using udnerscore in prefix for field
public class Circle
{
    double _Radius = 12.34;
    public double Radius
    {
        get {return Radius;} // Omit this to revoke the get access. Represetns a value returinign method without parameter
        set {Radius = value;} //Represents a non value returning method with parameter
    }
    
}

public class TestCircle
{
    static void Main()
    {
        Circle c = new Circle();
        double radius = c.Radius;
        c.Radius = 56.78;
    }
}
*/

/*
//Another big advantage of using property rather that using public acces modifier is Conditional access
public class Circle
{
    double _Radius = 12.34;
    public double Radius
    {
        get {return Radius;}
        set {
            if (value > _Radius)
             Radius = value;
            }
    }
}

public class TestCircle
{
    static void Main()
    {
        Circle c = new Circle();
        double radius = c.Radius;
        c.Radius = 12.34; // Value won't change
    }
}
*/
/*
public class Circle
{
    double _Radius = 12.34;
    public double Radius // Automatic Property or auto implemented property
    {
        get;
        protected set; //Only available to child class
    }
}

public class TestCircle
{
    static void Main()
    {
        Circle c = new Circle();
        double radius = c.Radius;
        c.Radius = 12.34; // Value won't change because current class is not a child class
    }
}
*/

// By default, access to attributes (like Radius) of entities (such as Circle) is private. This means you can't access or modify them.

// You can make attributes public, but this gives up control. Anyone can get or set the value.

// To control access, provide separate methods for getting and setting the value (GetRadius() and SetRadius()).

// A property combines these methods into a single entity. No need to declare parameters; they're implicitly declared. Syntax for a property: [<modifiers>] <type> <Name> { get {<stmts>} set {<stmts>} }. Properties provide cleaner code by using a single name for both getting and setting values.

// For large numbers of fields, use the convention of prefixing fields with an underscore.

// Properties allow for conditional access, such as restricting values based on conditions.

// Automatic properties provide a shortcut, eliminating the need to define separate methods for get and set.

//enum used