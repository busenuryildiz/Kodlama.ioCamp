using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int,int> person = new MyDictionary<string, int,int>();
            person.Add("furkan", 2,5);
            person.Add("buse", 1,6);
            person.Add("ayse", 4,7);
            person.Add("fatma", 3, 8);
        }
    }
}