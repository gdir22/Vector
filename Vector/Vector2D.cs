using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    /// <summary>
    /// A class for vectors in 2D. Only a excerpt of the actual implementation is shown here as a minimal example to 
    /// reproduce an issue with MS Test 2.2.4 to 2.2.10
    /// </summary>
    public class Vector2D
    {
        /// <summary>
        /// The U-component of the vector
        /// </summary>
        public double U { get; }

        /// <summary>
        /// The V-component of the vector
        /// </summary>
        public double V { get; }

        /// <summary>
        /// Constructor. Creates the vector in 2D with the given components.
        /// </summary>
        /// <param name="u">The U-component of the vector</param>
        /// <param name="v">The V-component of the vector</param>
        public Vector2D(double u, double v)
        {
            U = u;
            V = v;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>Returns a string that represents the current object.</returns>
        public override string ToString()
        {
            return FormattableString.Invariant($"Vector2D: {U:F3} / {V:F3}");
        }

        /// <summary>
        /// Scalar product of two Vector2D.
        /// </summary>
        /// <param name="v">The first Vector2D</param>
        /// <param name="w">The second Vector2D</param>
        /// <returns>Returns the scalar product (dot product) of the vectors.</returns>
        /// <exception cref="ArgumentNullException">Thrown if one or both vectors are null.</exception>
        public static double operator *(Vector2D v, Vector2D w)
        {
            _ = v ?? throw new ArgumentNullException(nameof(v), "The first vector must not be null.");
            _ = w ?? throw new ArgumentNullException(nameof(w), "The second vector must not be null.");

            return v.U * w.U + v.V * w.V;
        }
    }
}
