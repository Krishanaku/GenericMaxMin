namespace Generics
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Generic Max Min Problem");
            //int[] intArray = { 1, 2, 3, 4, 5, };
            //double[] doubleArray = { 1.1, 2.2, 3.3 };
            //char[] charArray = { 'K', 'r', 'i', 's','h' };

            //PrintArray<int> intPrintArray = new PrintArray<int>(intArray);
            //intPrintArray.toPrint();

            //PrintArray<double> intPrintArray = new PrintArray<double>(doubleArray);
            //doublePrintArray.toPrint();

            //PrintArray<char> intPrintArray = new PrintArray<char>(charArray);
            //charPrintArray.toPrint();


            int num1 = 20;
            int num2 = 80; 
            int num3 =77;
            //int value = num1.CompareTo(num2);
            //Console.WriteLine(value);
            int value = Maximum.MaximumIntNum(num1, num2, num3);
            Console.WriteLine(value +"is greatest number");



        }
    }
}