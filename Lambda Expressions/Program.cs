
namespace Project
{
    public delegate string GreetingsDelegate(string name);
    class LambdaExpressions
    {
        public static string Greetings(string name)
        {
            return "Hello" + name + "a very good morning";
        }
        static void Main()
        {
            //GreetingsDelegate obj = new GreetingDelegate(Greetings);
            /*
            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello" + name + "a very good morning";
            };
            */
            GreetingsDelegate obj = (string name) => { return "Hello" + name + "a very good morning";};

            string str = obj.Invoke("Scott");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}