namespace Generics
{
    public class Program
    {
        public static void toprint<T>(T[] intputArray)
            //<T> is generic inilization
            //T[] any type of data want to store
            //var is used beacuse u store diff data type so u can use var

        {
            foreach (var i in intputArray)
            {
                Console.WriteLine(i);
            }
        }
     
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Generic Max Min Problem");
            //string str = "Amit";
            //string str1 = "Sagar";
            //string str2 = "Krishna";


            int[] intArray = { 1, 2, 3, 4, 5};
            double[] doubleArray = { 1.1,2.1,3.1,4.1};
            char[] charArray = { 'a', 'k', 'l', 'n' };

            Program.toprint<int>(intArray);
            Program.toprint<double>(doubleArray);
            Program.toprint<char>(charArray);



            



            




        }
    }
}