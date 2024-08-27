// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemsBagTests.cs" company="PropertyTools">
//   Copyright (c) 2014 PropertyTools contributors
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PropertyTools.Wpf.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ItemsBagTests
    {
        [Test]
        public void SetValue_ReadOnlyProperty()
        {

            var t0 = new TestObject();
            var bag = new ItemsBag(new[] { t0 });
            var provider = new ItemsBagTypeDescriptionProvider();
            var td = provider.GetTypeDescriptor(typeof(ItemsBag), bag);
            var props = td.GetProperties();
            var p1 = props.Find("Checked", false);
            Assert.AreEqual(false, p1.IsReadOnly);
            p1.SetValue(bag, true);
            Assert.AreEqual(true, t0.Checked);
            Assert.AreEqual(true, t0.IsChecked);

//            var p2 = typeof(ItemsBag).GetProperty("IsChecked");
            var p2 = props.Find("IsChecked", false);

            Assert.AreEqual(true, p2.IsReadOnly);
            p2.SetValue(bag, false);
            Assert.AreEqual(false, t0.IsChecked);
        }

        private class TestObject
        {
            public bool IsChecked => this.Checked;
            public bool Checked { get; set; }
        }
    }
}