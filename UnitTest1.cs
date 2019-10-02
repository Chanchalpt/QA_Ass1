using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp21;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForEquilateralCaseOne()
        {
            //Arrange
            int one = 1;
            int two = 1;
            int three = 1;

            string expected = "It forms a equilateral triangle.";
            TriangleSolver.Analyze(one, two, three);

            //Act
            string actual = TriangleSolver.Analyze(one, two, three);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForEquilateralCaseTwo()
        {
            //Arrange
            int one = 10000;
            int two = 10000;
            int three = 10000;
            string expected = "It forms a equilateral triangle.";
            TriangleSolver.Analyze(one, two, three);

            //Act
            string actual = TriangleSolver.Analyze(one, two, three);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForIsoscelesCaseOne()
        {
            //Arrange
            int one = 8;
            int two = 12;
            int three = 8;
            string expected = "It forms a Isosceles triangle.";
            TriangleSolver.Analyze(one, two, three);

            //Act
            string actual = TriangleSolver.Analyze(one, two, three);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForIsoscelesCaseTwo()
        {
            //Arrange
            int one = 2400;
            int two = 3600;
            int three = 2400;
            string expected = "It forms a Isosceles triangle.";
            TriangleSolver.Analyze(one, two, three);

            //Act
            string actual = TriangleSolver.Analyze(one, two, three);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForScaleneCaseOne()
        {
            //Arrange
            int one = 5;
            int two = 3;
            int three = 4;
            string expected = "It forms a scalene triangle.";
            TriangleSolver.Analyze(one, two, three);

            //Act
            string actual = TriangleSolver.Analyze(one, two, three);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestForScaleneCaseTwo()
        {
            //Arrange
            int one = 77777;
            int two = 88888;
            int three = 66666;
            string expected = "It forms a scalene triangle.";
            TriangleSolver.Analyze(one, two, three);

            //Act
            string actual = TriangleSolver.Analyze(one, two, three);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForTriangleNotFormedCaseOne()
        {
            //Arrange
            int one = 3;
            int two = 2;
            int three = 1;
            string expected = "Cannot form a triangle.";
            TriangleSolver.Analyze(one, two, three);

            //Act
            string actual = TriangleSolver.Analyze(one, two, three);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForTriangleNotFormedCaseTwo()
        {
            //Arrange
            int one = 19555;
            int two = 10999;
            int three = 38888;
            string expected = "Cannot form a triangle.";
            TriangleSolver.Analyze(one, two, three);

            //Act
            string actual = TriangleSolver.Analyze(one, two, three);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
