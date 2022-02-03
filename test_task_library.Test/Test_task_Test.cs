using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test_task_library.Test
{
    [TestClass]
    public class Test_task_Test
    {
        [TestMethod]
      /*  public void Circle_r10_returned_S()
        {
            double r = 10;
            double expected = Math.PI * Math.Pow(r, 2);
            
            Test_task test_ = new Test_task();
            double actual = test_.Circle(r);

            Assert.AreEqual(expected, actual);
        }*/
        public void Triangle_a10_b_24_c26()
        {
            double a, b, c;
            a = 10; b = 24; c = 26;
            double expected = 120;

            Test_task test_ = new Test_task();
            double actual = test_.Triangle(a,b,c);

            Assert.AreEqual(expected, actual);
        }
    }
    }

