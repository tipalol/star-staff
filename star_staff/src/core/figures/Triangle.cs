﻿using System;
namespace star_staff.src.core.figures
{
    public class Triangle : IFigure
    {
        #region properties
        //Sides of triangle
        public uint A { get; }
        public uint B { get; }
        public uint C { get; }

        /// <summary>
        /// Returns perimeter of this triangle
        /// </summary>
        public uint Perimeter {
            get => A + B + C;
        }

        /// <summary>
        /// Returns half perimeter of this triangle
        /// </summary>
        public double HalfPerimeter {
            get => Perimeter / 2d;
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
        public double Square {
            get {
                double p = HalfPerimeter;
                double QuadroSquare = p * (p - A) * (p - B) * (p - C);

                return Math.Sqrt( QuadroSquare );
            }
        }
        #endregion

        /// <summary>
        /// Returns created triangle or null if this can not exist.
        /// Throws <see cref="InvalidFigureException"/>
        /// </summary>
        /// <param name="a">A side</param>
        /// <param name="b">B side</param>
        /// <param name="c">C side</param>
        public Triangle(uint a, uint b, uint c) {
            if (A + B > C || A + C > B || B + C > A)
                throw new InvalidCastException("Cannot create triangle with these parameters");

            A = a;
            B = b;
            C = c;
        }
    }
}
