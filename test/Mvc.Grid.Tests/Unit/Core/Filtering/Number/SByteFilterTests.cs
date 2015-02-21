﻿using NUnit.Framework;
using System;

namespace NonFactors.Mvc.Grid.Tests.Unit
{
    [TestFixture]
    public class SByteFilterTests
    {
        #region Method: GetNumericValue()

        [Test]
        public void GetNumericValue_ParsesValue()
        {
            SByteFilter filter = new SByteFilter();
            filter.Value = "-128";

            Object actual = filter.GetNumericValue();
            Object expected = -128;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetNumericValue_OnNotValidValueReturnsNull()
        {
            SByteFilter filter = new SByteFilter();
            filter.Value = "128";

            Assert.IsNull(filter.GetNumericValue());
        }

        #endregion
    }
}
