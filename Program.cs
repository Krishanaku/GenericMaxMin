namespace Generics
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Generic Max Min Problem");
            int a = Maximum<int>.Maximum1(10, 20, 30);
            double b = Maximum<double>.Maximum1(10.20, 20.03, 30.2);
            char c = Maximum<char>.Maximum1('A', 'C', 'B');
            Console.WriteLine("Greatest Int : " + a);
            Console.WriteLine("Greatest Double : " + b);
            Console.WriteLine("Greatest Char : " + c);


        }
    }
}
