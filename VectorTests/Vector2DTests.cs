using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vector;

namespace VectorTests
{
    /// <summary>
    /// Unit tests for Vector2D
    /// </summary>
    [TestClass]
    public class Vector2DTests
    {
        /// <summary>
        /// Test of the the operator *(Vector2D, Vector2D)
        /// </summary>
        /// <param name="v">The first vector</param>
        /// <param name="w">The second vector</param>
        /// <param name="expected">The expected result</param>
        [TestMethod]
        [DynamicData(nameof(Create_test_cases_for_scalar_product_of_two_vectors), DynamicDataSourceType.Method)]
        public void Vector2D_op_Multiplication_Vector2D_Vector2D___valid_Vector2D___double_scalar_product(Vector2D v, Vector2D w, double expected)
        {
            double actual = v * w;
            double delta = 0.00001;

            Assert.AreEqual(expected, actual, delta, "The scalar product hasn't been computed correctly.");
        }

        /// <summary>
        /// Creates test cases for the scalar multiplication of vectors.
        /// </summary>
        /// <returns>Returns the test cases. Each test case contains the two vectors and the expected result.</returns>
        private static IEnumerable<object[]> Create_test_cases_for_scalar_product_of_two_vectors()
        {
            return new[]
            {
                new object[] { new Vector2D(0.0, 0.0), new Vector2D(0.0, 0.0), 0.0 },
                new object[] { new Vector2D(1.0, 2.0), new Vector2D(0.0, 0.0), 0.0 },
                new object[] { new Vector2D(0.0, 0.0), new Vector2D(2.0, 3.0), 0.0 },
                new object[] { new Vector2D(1.0, 3.0), new Vector2D(1.0, 2.0), 7.0 },
                new object[] { new Vector2D(-1.0, -2.0), new Vector2D(-3.4, 2.75), -2.1 },
                new object[] { new Vector2D(3.355, -2.211), new Vector2D(12.43, -2.754), 47.791744 },
                new object[] { new Vector2D(-0.15, 2.03), new Vector2D(4.23, 6.81187), 13.1935961},
                new object[] { new Vector2D(-22.7231, -78.2976), new Vector2D(-17.4327, -8.1956), 1037.82079593}
            };
        }
    }
}
