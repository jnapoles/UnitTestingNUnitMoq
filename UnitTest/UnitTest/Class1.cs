﻿using System;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class Class1
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Method1() {
            Assert.Fail();
        }
    }
}
