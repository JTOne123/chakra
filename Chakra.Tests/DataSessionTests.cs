﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZenProgramming.Chakra.Core.Data;
using ZenProgramming.Chakra.Core.Data.Mockups;

namespace Chakra.Tests
{
    [TestClass]
    public class DataSessionTests
    {
        [TestMethod]
        public void VerifyThatMockDataSessionCanBeCreated()
        {
            SessionFactory.RegisterDefaultDataSession<MockupDataSession>();
            IDataSession session = SessionFactory.OpenSession();
            Assert.IsTrue(session is MockupDataSession);
        }
        
    }
}
