using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using ClassLibrary1;

namespace Test
{

    [TestFixture]
        public class UnitTest1
        {
            [Test]
            public void TestMethod1()
            {
                double a = 1;
                double b = -5;
                double c = 4;
                double[] x1 = { 4, 1 };
                double[] x2 = Sqrt.Calc(a, b, c);
                Assert.AreEqual(x1, x2);
            }
        }
    }

