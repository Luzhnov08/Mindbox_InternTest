using System;
using Xunit;
using Task0;

namespace FigureTests
{
    public class UnitTestMethods
    {
        [Fact]
        public void CircleSquareTest()
        {
            //arrange            
            double sqExpect = 65.325;
            //act
            Circle circle = new Circle(4.56);
            double sqActual = Math.Round(circle.Square(), 3);
            //assert
            Assert.Equal(sqExpect, sqActual);
        }

        [Fact]
        public void TriangleSquareTest()
        {
            //arrange            
            double sqExpect = 6.156;
            //act
            Triangle triangle = new Triangle(3.04, 4.05, 5.06);
            double sqActual = Math.Round(triangle.Square(), 3);
            //assert
            Assert.Equal(sqExpect, sqActual);
        }

        [Fact]
        public void TriangleIsRectangularTest()
        {
            //arrange            
            bool rectExpect = true;
            //act
            Triangle triangle = new Triangle(3, 4, 5);
            bool rectActual = triangle.CheckRectangular();
            //assert
            Assert.Equal(rectExpect, rectActual);
        }

        [Fact]
        public void TriangleIsExistTest()
        {
            //arrange            
            bool resExpect = true;
            //act
            Triangle triangle = new Triangle(3, 4, 5);
            bool resActual = triangle.IsExist();
            //assert
            Assert.Equal(resExpect, resActual);
        }

        [Fact]
        public void TriangleNotExistTest()
        {
            //arrange            
            bool resExpect = false;
            //act
            Triangle triangle = new Triangle(3, 2, 9);
            bool resActual = triangle.IsExist();
            //assert
            Assert.Equal(resExpect, resActual);
        }
    }
}