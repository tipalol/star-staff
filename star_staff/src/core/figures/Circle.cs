using System;
namespace star_staff.src.core.figures
{
    public class Circle : IFigure
    {
        #region properties
        /// <summary>
        /// Returns radius of this circle
        /// </summary>
        public uint Radius { get; }

        /// <summary>
        /// Returns square of this circle
        /// </summary>
        public double Square {
            get => Math.PI * Radius * Radius;
        }
        #endregion

        /// <summary>
        /// Returns created circle
        /// </summary>
        /// <param name="radius">Radius</param>
        public Circle(uint radius)
        {
            Radius = radius;
        }
    }
}
