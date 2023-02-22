namespace Generics
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Generic Max Min Problem");
            //string str = "Amit";
            //string str1 = "Sagar";
            //string str2 = "Krishna";

            Maximum maximum = new Maximum();
           string smax=maximum.FindMxString("kka","ll","mmii");
            Console.WriteLine(smax + " is greatest string");
            




        }
    }
}