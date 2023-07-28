using NUnit.Framework;
using DevToys.Api.Tools;
using System;

namespace DevToys.Api.Tools.Test
{
    public class TestProtocolNameAttribute
    {
        [Test]
        public void TestProtocolNameAttribute_ProtocolNameAttribute_a10010caa7()
        {
            // Test for valid protocol name
            ProtocolNameAttribute pna = new ProtocolNameAttribute("protocol1");
            Assert.AreEqual("protocol1", pna.ProtocolName);

            // Test for invalid protocol name
            Assert.Throws<ArgumentException>(() => new ProtocolNameAttribute("Protocol2"));

            // Test for null protocol name
            Assert.Throws<ArgumentException>(() => new ProtocolNameAttribute(null));

            // Test for empty protocol name
            Assert.Throws<ArgumentException>(() => new ProtocolNameAttribute(""));
        }
    }
}
