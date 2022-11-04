using System;
using System.Collections.Generic;

namespace Square
{
    public class SquareCounter
    {
        private FigureType _figureType;
        public double Square { get;  set; }

        public double GetSquare(double radius)
        {
            _figureType = FigureType.Circle;
            Square = Math.PI * radius * radius;
            return Square;
        }

        public double GetSquare(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Square = S;

            var arr = new List<double> { a, b, c };
            var max = 0.0;
            foreach (var el in arr)
            {
                if (el > max) max = el;
            }
            arr.Remove(max);
            var maxSquare = max * max;
            var sumSquare = 0.0;
            var sum = 0.0;
            foreach (var el in arr)
            {
                sumSquare += el * el;
                sum += el;
            }
            if (maxSquare == sumSquare && max < sum) _figureType = FigureType.TriangleRect;
            else _figureType = FigureType.TriangleDefault;
            return S;
        }


        public bool isRect()
        {
            if (_figureType == FigureType.Circle) return false;
            if (_figureType == FigureType.TriangleRect) return true;
            else return false;
        }

        

    }
}
