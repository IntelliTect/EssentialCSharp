using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_09.Tests
{
    [TestClass]
    public class ArcTests
    {
        [TestMethod]
        public void ArcUnaryMinus_InvertSignOfArc()
        {
            Arc arc = new Arc(new Longitude(48), new Latitude(12));
            arc = -arc;
            
            Assert.AreEqual(-48, arc.LongitudeDifference.Degrees);
            Assert.AreEqual(-12, arc.LatitudeDifference.Degrees);
        }
    }

    [TestClass]
    public class CoordinateTests
    {
        [TestMethod]
        public void ArcUnaryPlus_KeepSignOfArc()
        {
            Arc arc = new Arc(new Longitude(48), new Latitude(12));
            arc = +arc;
            
            Assert.AreEqual(48, arc.LongitudeDifference.Degrees);
            Assert.AreEqual(12, arc.LatitudeDifference.Degrees);
        }
        
        
        [TestMethod]
        public void CoordinateEquals_GivenEqualObjects_AreEqual()
        {
            Coordinate coordinate1 = new Coordinate(new Longitude(48, 52), 
                new Latitude(-2, -20));
            Coordinate coordinate2 = new Coordinate(new Longitude(48, 52), 
                new Latitude(-2, -20));
            
            Assert.IsTrue(coordinate1.Equals(coordinate2));
        }

        [TestMethod]
        [DataRow(48, 52, -2, -20, 49, 52, -2, -20)]
        [DataRow(48, 52, -2, -20, 48, 53, -2, -20)]
        [DataRow(48, 52, -2, -20, 48, 52, 0, -20)]
        [DataRow(48, 52, -2, -20, 48, 52, -2, -10)]
        public void CoordinateNotEquals_GivenDifferentObjects_NotEqual(int longDegrees1, int longMinutes1,
            int latDegrees1, int latMinutes1, int longDegrees2, int longMinutes2, int latDegrees2, int latMinutes2)
        {
            Coordinate coordinate1 = new Coordinate(new Longitude(longDegrees1, longMinutes1), 
                new Latitude(latDegrees1, latMinutes1));
            Coordinate coordinate2 = new Coordinate(new Longitude(longDegrees2, longMinutes2), 
                new Latitude(latDegrees2, latMinutes2));
            
            Assert.IsTrue(coordinate1 != coordinate2);
        }

        [TestMethod]
        public void CoordinateEquals_GivenNull_NotEqual()
        {
            Coordinate coordinate1 = new Coordinate(new Longitude(48, 52), 
                new Latitude(-2, -20));
            Coordinate? coordinate2 = null;
            
            Assert.IsFalse(coordinate1.Equals(coordinate2!));
        }

        [TestMethod]
        public void CoordinateEquals_GivenSameReference_Equal()
        {
            Coordinate coordinate1 = new Coordinate(new Longitude(48, 52), 
                new Latitude(-2, -20));
            Coordinate coordinate2 = coordinate1;
            
            Assert.IsTrue(coordinate1 == coordinate2);
        }

        [TestMethod]
        public void CoordinateEquals_GivenDifferentTypes_NotEqual()
        {
            Coordinate coordinate1 = new Coordinate(new Longitude(48, 52), 
                new Latitude(-2, -20));
            int otherObj = 12;
            
            Assert.IsFalse(coordinate1.Equals(otherObj));
        }


        [TestMethod]
        public void CoordinateAdd_GivenArc_CoordinateOffset()
        {
            Coordinate coordinate = new Coordinate(new Longitude(48, 52), 
                new Latitude(-2, -20));
            Arc arc = new Arc(new Longitude(3), new Latitude(1));
            coordinate += arc;
            
            Assert.AreEqual(51, coordinate.Longitude.Degrees);
            Assert.AreEqual(52, coordinate.Longitude.Minutes);
            Assert.AreEqual(-1, coordinate.Latitude.Degrees);
            Assert.AreEqual(-20, coordinate.Latitude.Minutes);
        }

        [TestMethod]
        public void CoordinateSubtract_GivenArc_CoordinateOffset()
        {
            Coordinate coordinate = new Coordinate(new Longitude(48, 52), 
                new Latitude(-2, -20));
            Arc arc = new Arc(new Longitude(3), new Latitude(1));
            coordinate -= arc;
            
            Assert.AreEqual(45, coordinate.Longitude.Degrees);
            Assert.AreEqual(52, coordinate.Longitude.Minutes);
            Assert.AreEqual(-3, coordinate.Latitude.Degrees);
            Assert.AreEqual(-20, coordinate.Latitude.Minutes);
        }

        [TestMethod]
        public void CoordinateToString_ValidateCoordinate()
        {
            Coordinate coordinate = new Coordinate(new Longitude(48, 52), 
                new Latitude(-2, -20));

            string expected = @"48° 52' 0 E -2° -20' 0 N";
            
            Assert.AreEqual(expected, coordinate.ToString());
        }
    }
}
