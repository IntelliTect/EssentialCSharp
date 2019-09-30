using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_11.Tests
{
    [TestClass]
    public class LatitudeTests
    {
        [TestMethod]
        public void LatitudeDoubleCast_GivenValidLatitude_CastDegreesToDouble()
        {
            Latitude latitude = new Latitude(12);

            Double castTo = (Double) latitude;
            
            Assert.AreEqual(12.00, castTo);
        }

        [TestMethod]
        public void LatitudeCast_GivenValidLatitude_CastDoubleToLatitude()
        {
            Double d = 12.00;

            Latitude castTo = (Latitude) d;
            
            Assert.AreEqual(12.00, castTo.DecimalDegrees);
        }
    }
}
