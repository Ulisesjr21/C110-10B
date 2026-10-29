
namespace HelloWorld
{
    public class Greeting
    {
        public string Name { get; set; }

        public Greeting(string name)
        {
            Name = name;
        }

        public string BuildMessage()
        {
            return "Hello world, " + Name + "!";
        }
    }
}
