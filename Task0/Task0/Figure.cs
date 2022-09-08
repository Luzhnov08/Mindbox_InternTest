using System;

/* Напишите на С# библиотеку для поставки внешним клиентам, 
* которая умеет вычислять площадь круга по радиусу и треугольника по трём сторонам.  
* дополнительно: 
* Юнит-тесты +
* Легкость добавления других фигур +
* Вычисление площади фигуры без знания типа фигуры в compile-time ?
* проверку на то, является ли треугольник прямоугольным + */

namespace Task0
{
    public abstract class Figure
    {
        protected double _a;
        protected double _b;
        protected double _c;

        public Figure()
        {

        }

        public Figure(double a)
        {
            _a = a;
        }
        public Figure(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
    }
    /// <summary>
    /// Объект фигуры окружность
    /// </summary>
    public class Circle : Figure 
    {
        public Circle(double a) : base(a) { }
        /// <summary>
        /// Вычисляет площадь окружности с указанным радиусом
        /// </summary>
        /// <returns>тип <c>double</c></returns>
        public double Square()  //S = pr2;
        {
            double circleSq = Math.PI * Math.Pow(this._a, 2);
            return circleSq;
        }
    }
    /// <summary>
    /// Объект фигуры треугольник
    /// </summary>
    public class Triangle : Figure
    {
        public Triangle(double a, double b, double c) : base(a,b,c) { }
        /// <summary>
        /// Вычисляет площадь треугольника с указанными сторонами
        /// </summary>
        /// <returns>тип <c>double</c></returns>
        public double Square()  
        {
            if (IsExist())
            {
                double hPer = (_a + _b + _c) / 2; //halfPerimeter
                double triangleSq = Math.Sqrt(hPer * (hPer - _a) * (hPer - _b) * (hPer - _c)); //S = sqrt(p(p-a)(p-b)(p-c))
                return triangleSq;
            }
            else return -1;
        }

        /// <summary>
        /// Проверка является ли треугольник с указанными сторонами прямоугольным
        /// </summary>
        /// <returns><c>true</c> - да, является; <c>false</c> - нет, не является</returns>
        public bool CheckRectangular()
        {
            bool rect = false;
            if (IsExist())
            {
                rect = Equals(_c * _c, _a * _a + _b * _b);
            }
            return rect;
        }

        /// <summary>
        /// Проверка существования треугольника с указанными сторонами
        /// </summary>
        /// <returns>false если треугольник не существует, true - если существует</returns>
        public bool IsExist() 
        {
            if (_a >= _b + _c || _b >= _a + _c || _c >= _a + _b) return false;
            return true;
        }
    }

    public class Another : Figure
    {

    }
}
