using System;
using Assignment1.Math;
namespace Assignment1
{
    public class Man
    {
        public int age;
    }
    class MainClass
    {
        public static void Main(string[] args)
        {

            var sajid = new Person();
            sajid.FirstName = "Sajid";
            sajid.LastName = "khan";
            sajid.Introduce();
            Console.WriteLine();
            //calculator class
            //var cal = new Calculator();
            // *** static implementation ***
            var result = Calculator.add(1, 2);
            Console.WriteLine(result);
            //Array
            Console.WriteLine();
            int[] number = new int[3];
            number[0] = 1;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine();
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            // *** String ***
            var firstName = "sajid";
            var lastName = "Khan";
            var fullName = string.Format("My name is {0}{1}", firstName, lastName);
            var names = new string[3] { "chand", "Sultana", "siddiqua"};
            var combainedName = string.Join(" ", names);
            Console.WriteLine(fullName);
            Console.WriteLine("Spouse Name: {0}",combainedName);

            var text = "Hi there!\nPlz follow this path\nC:\\folder1\\folder2";
            Console.WriteLine(text);
            var text2 = @"Hi there!
                        Plz follow this path
                        C:\folder2\folder3";
            Console.WriteLine(text2);

            // *** Value types and Reference type example ***

            // *** Value types example1 ***
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("a :{0}, b:{1}",a,b);
            // ***  Reference type example1 ***
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            Console.WriteLine("Before :: array1[0] :{0} , array1[1] :{1}", array1[0], array2[0]);
            array2[0] = 0;
            Console.WriteLine("After :: array1[0] :{0} , array1[1] :{1}", array1[0],array2[0]);

            // *** Value types example2 ***
            var num = 1;
            // Increament methods argument 'num'  is different from var 'num'
            Increment(num);
            // after value incremented by 10 the argument 'num' is immediately destroyed
            Console.WriteLine(num);// 1

            // ***  Reference type example2 ***
            var m = new Man() { age=20};
            //Here agrument 'man' obejct is references same object 'man' in Heap
            MakeOld(m);
            Console.WriteLine(m.age);


            void Increment(int n)
            {
                n += 10;
            }
            void MakeOld(Man man)
            {
                man.age += 10;
            }


        }
    }
}
