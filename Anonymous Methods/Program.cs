/*
Anonymous Methods: Without binding a named method to a delegate you can bind a unnamed code block to a delegate.
*/
namespace Project
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethods
    {
        public static string Greetings(string name)
        {
            return "Hello" + name + "a very good morning";
        }
        static void Main()
        {
            //GreetingsDelegate obj = new GreetingDelegate(Greetings);
            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello" + name + "a very good morning";
            };
            string str = obj.Invoke("Scott");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}