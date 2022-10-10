namespace RefValTypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            //when location "a" is duplicated on stack to location "b", "b" exists independently of "a" which is why increment only affected "b"
            Console.WriteLine(String.Format("a: {0}, b: {1}", a, b));
        }
    }
}