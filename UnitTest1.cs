using System;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Add
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 10;
            int b = 20;
            int expected = 30;

            //Act 

            int result = Starting_with_MSTest.Program.add(a, b);

               //Assert
            Assert.AreEqual(expected, result);
            
            }
    }
}
