using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    [Author("Rushit Patel", "abc@gmail.com")]
    [Author("Shin Chan", "Shin.chan@example.com")]
    [Author("Another Developer", "email@example.com")]
    public class Attribute
    {


        [Test(Author = "Shin Chan")]
        public void Test1()
        { /* ...
            
             
        */ }


        [Test]
        [Author("RJ Patel")]
        [Author("Yet Another Developer", "not.my.email@example.com")]
        public void Test2()
        {
            /* ... */

        }





    }
}
