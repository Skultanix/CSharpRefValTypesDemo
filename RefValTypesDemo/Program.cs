namespace RefValTypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(String.Format("a: {0}, b: {1}", a, b));
        }
    }
}