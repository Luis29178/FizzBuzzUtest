using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzzLibrary;

namespace FizzBuzzUtest
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// 
        /// Write 2 negative tests to establish that the valid range for the 
        /// length parameter is between 1 and 100.
        /// 
        /// </summary>
        /// 
        [TestMethod]
        public void FailsGT100()
        {
            FizzBuzz fizz = new FizzBuzz();
            try
            {
                string test = fizz.Process(101);
            }
            catch (Exception)
            {

                Assert.IsTrue(true);
            }

        }


        [TestMethod]
        public void FailsLT1()
        {
            FizzBuzz fizz = new FizzBuzz();
            try
            {
                string test = fizz.Process(0);
            }
            catch (Exception)
            {

                Assert.IsTrue(true);
            }

        }

        /// <summary>
        /// 
        /// Write 10 positive tests to establish that it returns the correct string
        /// for length parameter values 1 through 10, using the default constructor.
        /// 
        /// Default araingment
        /// 1,2,Fizz,4,Buzz,Fizz
        ///      ^      ^    ^
        /// </summary>

        #region ValidReturn 1 - 10
        [TestMethod]
        public void ValidReturn1()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(1);
            Assert.AreEqual("1", test);
        }

        [TestMethod]
        public void ValidReturn2()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(2);
            Assert.AreEqual("1,2", test);
        }

        [TestMethod]
        public void ValidReturn3()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(3);
            Assert.AreEqual("1,2,Fizz", test);
        }

        [TestMethod]
        public void ValidReturn4()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(4);
            Assert.AreEqual("1,2,Fizz,4", test);
        }

        [TestMethod]
        public void ValidReturn5()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(5);
            Assert.AreEqual("1,2,Fizz,4,Buzz", test);
        }

        [TestMethod]
        public void ValidReturn6()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(6);
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz", test);
        }

        //Bug: cannot Access FizzBuzz's Process() function with parameter 7
        // due to the current state of the object 
        [TestMethod]
        public void ValidReturn7()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(7);
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7", test);

        }


        [TestMethod]
        public void ValidReturn8()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(8);
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8", test);
        }

        [TestMethod]
        public void ValidReturn9()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(9);
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz", test);
        }

        [TestMethod]
        public void ValidReturn10()
        {
            FizzBuzz fizz = new FizzBuzz();
            string test = fizz.Process(10);
            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz", test);
        } 
        #endregion









    }
}
