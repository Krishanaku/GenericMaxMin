namespace Generics
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Generic Max Min Problem");
            string str = "Amit";
            string str1 = "Sagar";
            string str2 = "Krishna";

            string Max = Maximum.MaximumString(str, str1, str2);
            Console.WriteLine(Max);



        }
    }
}