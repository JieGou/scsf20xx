//===============================================================================
// Microsoft patterns & practices
// Smart Client Software Factory 2010
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Microsoft.Practices.CompositeUI.Utility.Tests
{
    [TestClass]
    public class DataEventArgsFixture
    {
        [TestMethod]
        public void IsCreatable()
        {
            DataEventArgs<int> e = new DataEventArgs<int>(32);
            Assert.IsNotNull(e, "Cannot create an instance of ApplicationEventArgs");
        }

        [TestMethod]
        public void CanPassData()
        {
            DataEventArgs<int> e = new DataEventArgs<int>(32);
            Assert.AreEqual(32, e.Data);
        }

        [TestMethod]
        public void IsEventArgs()
        {
            Assert.IsTrue(typeof(EventArgs).IsAssignableFrom(typeof(DataEventArgs<int>)), "ApplicationEventArgs is not a subtype of EventArgs");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowsIfDataIsNull()
        {
            DataEventArgs<object> data = new DataEventArgs<object>(null);
        }
    }
}
