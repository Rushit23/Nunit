using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
   public class Attributes
    {

        // TimeOut Attribute

        [Test, Timeout(2000)]
        public void  TimeOAttribute()
        {
           
        }






        // Repeat Attribute

        [Test]
        [Repeat(10)]
        public void test3()
        {
            /* ... */
        }







        // Retry Attribute

       [Test]
        [Retry(3)]
        public void test4([Values(1, 2, 3)] int x, [Range(2, 6)] double y)
        {
            //


        }




        // Range Attribute


        [Test]
        public void MyTest([Values(1, 2, 3)] int x, [Range(0.2, 0.6, 0.2)] double d)
        {
          


        }






        // Random Attribute


        [Test]
        public void MyTest3 ([Values(1, 2, 3)] int x, [Random(-1.0, 1.0, 5)] double d)


        {
           //
        }




        // Combinatorial Attribute

        [Test, Combinatorial]
        public void MyTest([Values(1, 2, 3)] int x, [Values("A", "B")] string s)


        {
            //
        }



        [Test, Combinatorial]
        public void ExampleTest([Values(1, 2, 3, 4)] int a, [Values("A", "B", "C")] string b, [Values("x", "y", "z")] string c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }




        // Pairwise Attribute

        [Test, Pairwise]
        public void ExampleTest2 ([Values(1, 2, 3, 4)] int a, [Values("A", "B", "C")] string b, [Values("x", "y", "z")] string c)



        {
            Console.WriteLine(a + " " + b + " " + c);
        }





    }
}
