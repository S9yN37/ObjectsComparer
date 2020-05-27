﻿using NUnit.Framework;

namespace ObjectsComparer.Tests
{
    [TestFixture]
    public class DifferenceTests
    {
        [Test]
        public void DifferenceToString()
        {
            var difference = new Difference("Group1", "Property1", "12345", "12346");

            var toString = difference.ToString();

            Assert.IsTrue(toString.Contains("Group1"));
            Assert.IsTrue(toString.Contains("Property1"));
            Assert.IsTrue(toString.Contains("12345"));
            Assert.IsTrue(toString.Contains("12346"));
        }
    }
}