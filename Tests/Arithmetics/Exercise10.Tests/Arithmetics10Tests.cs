using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise10.Tests
{
    [TestClass]
    public class Arithmetics10Tests
    {
        [DataTestMethod]
        [DataRow(2.00, 12.56)]
        public void AreaOfCircle_FindAreaOfCircleFromRadius2_AreaOfCircleExpeted12_56(double radius, double expeted)
        {
            //Arrange
            var PI = 3.14;

            //Act
            var actual = Geometry.AreaOfCircle(radius, PI);

            //Assert
            Assert.AreEqual(expeted, actual);
        }

        [DataTestMethod]
        [DataRow(2.00, 3.00, 6.00)]
        public void AreaOfRectangle_FindAreaOfRectangleFromLenght2_Width3_AreaOfRectangleExpeted6(double length, double width, double expeted)
        {
            //Act
            var actual = Geometry.AreaOfRectangle(length, width);

            //Assert
            Assert.AreEqual(expeted, actual);
        }

        [DataTestMethod]
        [DataRow(2.00, 12.00, 12.00)]
        public void AreaOfTriangle_FindAreaOfTriangleFromGround2_H12_AreaOfTriangleExpeted12(double ground, double height, double expeted)
        {
            //Act
            var actual = Geometry.AreaOfTriangle(ground, height);

            //Assert
            Assert.AreEqual(expeted, actual);
        }
    }
}

