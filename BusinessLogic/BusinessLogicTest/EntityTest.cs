using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityTest
    {
        [TestMethod]
        public void NewEntityTest()
        {
            Entity aEntity = new Entity("AName");
            Assert.IsNotNull(aEntity);
        }
    }
}
