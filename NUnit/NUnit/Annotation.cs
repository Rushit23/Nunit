using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
  public class Annotation
    {



        [OneTimeSetUp]
        public void ClassInit()
        {


            // Executes once for the test class. (Optional)
        }




        [SetUp]
        public void TestInit()
        {



            // Runs before each test. (Optional)
        }





        [Test]
        public void TestMethod()
        {



        }




        [TearDown]
        public void TestCleanup()
        {


            // Runs after each test. (Optional)
        }






        [OneTimeTearDown]
        public void ClassCleanup()
        {
            // Runs once after all tests in this class are  executed. (Optional)

            // Not guaranteed that it executes instantly after all  tests from the class.

        }





    }
}
