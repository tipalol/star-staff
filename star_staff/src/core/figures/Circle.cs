using System;
namespace star_staff.src.core.figures
{
    public class Circle : IFigure
    {
        #region properties
        /// <summary>
        /// Returns radius of this circle
        /// </summary>
        public int Radius { get; }

        /// <summary>
        /// Returns square of this circle
        /// </summary>
        public double Square { get; }
        #endregion

        public Circle(int radius)
        {
            Radius = radius;
        }
    }
}
