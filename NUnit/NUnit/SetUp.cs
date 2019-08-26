using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{

    // A SetUpFixture outside of any namespace provides  SetUp and TearDown for the entire assembly.




    [SetUpFixture]
    public class SetUp
    {


        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            // Executes once before the test run. 
        }



        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            // Executes once after the test run.
        }

    }



}
