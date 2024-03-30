/* 
public class Entity
{
    int id;
    string attribute1, attribute2, attribute3;
    double number;
    public Entity(int id, string attribute1, string attribute2, string attribute3, double number) {
        this.id = id;
        this.attribute1 = attribute1;
        this.attribute2 = attribute2;
        this.attribute3 = attribute3;
        this.number = number;
    }
    // An indexer is a special type of property that allows you to access elements in a class or structure using array-like syntax. It provides a way to treat an object as an array.
    public object this[int index]
    {
        get
        {
            if(index == 0) return id;
            if(index == 1) return attribute1;
            if(index == 2) return attribute2;
            if(index == 3) return attribute3;
            if(index == 4) return number;
            return null;
        }
        set 
        {
            if(index == 0) id = (int)value;
            if(index == 1) attribute1 = (string)value;
            if(index == 2) attribute2 = (string)value;
            if(index == 3) attribute3 = (string)value;
            if(index == 4) number = (double)value;
        }

    }
}
class TestEntity
{
    static void Main()
    {
        Entity E = new Entity(1, "abc", "def", "xyz", 49.50);
        Console.WriteLine(E[1]);
        Console.WriteLine(E[2]);
        E[1] = 2;
    }
}
*/
/*
public class Entity
{
    int id;
    string attribute1, attribute2, attribute3;
    double number;
    public Entity(int id, string attribute1, string attribute2, string attribute3, double number) {
        this.id = id;
        this.attribute1 = attribute1;
        this.attribute2 = attribute2;
        this.attribute3 = attribute3;
        this.number = number;
    }
    public object this[string name]
    {
        get
        {
            if(name.ToUpper() == "ID") return id;
            if(name.ToUpper() == "ATTRIBUTE1") return attribute1;
            if(name.ToUpper() == "ATTRIBUTE2") return attribute2;
            if(name.ToUpper() == "ATTRIBUTE3") return attribute3;
            if(name.ToUpper() == "NUMBER") return number;
            return null;
        }
        set 
        {
            if(name.ToUpper() == "ID") id = (int)value;
            if(name.ToUpper() == "ATTRIBUTE1") attribute1 = (string)value;
            if(name.ToUpper() == "ATTRIBUTE2") attribute2 = (string)value;
            if(name.ToUpper() == "ATTRIBUTE3") attribute3 = (string)value;
            if(name.ToUpper() == "NUMBER") number = (double)value;
        }

    }
}
class TestEntity
{
    static void Main()
    {
        Entity E = new Entity(1, "abc", "def", "xyz", 49.50);
        Console.WriteLine(E["id"]);
        Console.WriteLine(E["Number"]);
        E["attribute2"] = "mno";
    }
}
*/