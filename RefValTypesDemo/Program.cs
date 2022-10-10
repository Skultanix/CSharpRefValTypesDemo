namespace RefValTypesDemo
{
    public class Person
    {
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            //when location "a" is duplicated on stack to location "b", "b" exists independently of "a" which is why increment only affected "b"
            Console.WriteLine(String.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //array1 and array2 have the same memory address, so any changes to the object on the heap will impact both of them.
            Console.WriteLine(String.Format("array1[0]: {0}, array2[0]: {0}", array1[0], array2[0]));

            //////////////Part 2////////////////



        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
    
}