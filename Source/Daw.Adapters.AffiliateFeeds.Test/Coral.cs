using System;
using Daw.Common.Entities;
using DAW.Adapters.AffiliateFeeds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daw.Adapters.AffiliateFeeds.Test
{
    [TestClass]
    public class CoralTest
    {
        [TestMethod]
        public void TestCoralUrl()
        {
            var feed = new Coral();
            feed.ReadFeed(@"http://xmlfeeds.coral.co.uk/oxi/pub?template=getNextEvents&category=FOOTBALL&numMarkets=5&output=xml", ConstantsAndEnums.SportEnum.Football);
        }
    }
}
