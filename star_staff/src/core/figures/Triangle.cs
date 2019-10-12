using System;
namespace star_staff.src.core.figures
{
    public class Triangle : IFigure
    {
        #region properties
        //Sides of triangle
        public int A { get; }
        public int B { get; }
        public int C { get; }

        /// <summary>
        /// Returns perimeter of this triangle
        /// </summary>
        public int Perimeter {
            get => A + B + C;
        }

        /// <summary>
        /// Returns half perimeter of this triangle
        /// </summary>
        public double HalfPerimeter {
            get => Perimeter / 2;
        }

        /// <summary>
        /// Returns true if this triangle is right
        /// </summary>
        public bool IsRight {
            get => (A * A + B * B == C * C)
                || (B * B + C * C == A * A)
                || (C * C + A * A == B * B);
        }

        /// <summary>
        /// Returns square of this triangle
        /// </summary>
        /// Why we dont use the right triangle fact?
        /// Just because it would be less effective
        /// In Gerone formule we have 1 divide operator and 3 multiply operators
        /// However, even to check rightness we have to calculate multiply operation
        /// 9 (!) times
        public double GetSquare {
            get {
                double p = HalfPerimeter;
                double QuadroSquare = p * (p - A) * (p - B) * (p - C);

                return Math.Sqrt( QuadroSquare );
            }
        }
        #endregion

        public Triangle(int a, int b, int c) {
            A = a;
            B = b;
            C = c;
        }
    }
}
