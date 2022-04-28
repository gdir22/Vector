using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    /// <summary>
    /// A struct for vectors in 2D. Only a excerpt of the actual implementation is shown here as a minimal example to 
    /// reproduce an issue with MS Test 2.2.4 to 2.2.10
    /// </summary>
    public struct Vector2D
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
        /// Multiplication of a Vector2D by a real number.
        /// </summary>
        /// <param name="v">The Vector2D</param>
        /// <param name="d">The real number</param>
        /// <returns>Returns the multiplication result.</returns>
        public static Vector2D operator *(Vector2D v, double d)
        {
            return new Vector2D(v.U * d, v.V * d);
        }

        /// <summary>
        /// Multiplication of a real number and a Vector2D.
        /// </summary>
        /// <param name="d">The real number</param>
        /// <param name="v">The Vector2D</param>
        /// <returns>Returns the multiplication result.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the vector is null.</exception>
        public static Vector2D operator *(double d, Vector2D v)
        {
            return new Vector2D(d * v.U, d * v.V);
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
            return v.U * w.U + v.V * w.V;
        }
    }
}
