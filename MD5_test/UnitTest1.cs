using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MD5_lib
{
    [TestClass]
    public class TestMD5
    {
        [TestMethod]
        public void EmptyHash()
        {
            string sourceDataString = "";
            MemoryStream input = new MemoryStream(Encoding.Default.GetBytes(sourceDataString));
            MemoryStream output = new MemoryStream();
            MD5 md5 = new MD5();
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            md5.GetHash(input, output);

            string myHash = Encoding.Default.GetString(output.ToArray()).TrimEnd('\0');
            Assert.AreEqual(comparer.Compare(myHash, "d41d8cd98f00b204e9800998ecf8427e"), 0);
        }
    }
}
