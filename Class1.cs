
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolver
{

    [TestFixture]
    public class Class1
    {
        [Test]
        public void AnalyzeTriangle_InputIsEquilateral_ReturnsEquilateral()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("Equilateral triangle"));
        }
        [Test]
        public void AnalyzeTriangle_ValidIsosceles1_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }
        

    }

}
