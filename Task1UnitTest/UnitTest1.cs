using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                //IsCompleted will return false as CallMethod() is running in background 
                //and control will come back to Assert
                Assert.IsFalse(Program.CallMethod().IsCompleted);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
