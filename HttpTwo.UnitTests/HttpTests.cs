using System;
using System.Collections.Specialized;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HttpTwo.UnitTests
{
    [TestClass]
    public class HttpTests
    {
        [TestMethod]
        public void TestMethod1Async()
        {
            string url = "https://cdn-dl.fotoable.com/conf/test-now/testnowConfig.json";
            //string url = "https://static.zhihu.com/heifetz/main.raven.887de2ac64cec5fbc8e2.js";
            var uri = new Uri(url);

            // Create a Http2Client
            var http2 = new Http2Client(uri);
            var headers = new NameValueCollection();
            byte[] data = null;

            var response = http2.Send(uri, HttpMethod.Get, headers, data).GetAwaiter().GetResult();

            Assert.IsTrue(response.Status == System.Net.HttpStatusCode.OK);
        }
    }
}
