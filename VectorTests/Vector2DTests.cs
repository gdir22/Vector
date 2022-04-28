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
        /// Test of the the operator *(Vector2D, double)
        /// </summary>
        /// <param name="v">The Vector2D</param>
        /// <param name="d">The real number</param>
        /// <param name="expected">The expected result</param>
        [TestMethod]
        [DynamicData(nameof(Create_test_cases_for_multiplication_of_vector_and_real), DynamicDataSourceType.Method)]
        public void Vector2D_op_Multiplication_Vector2D_double___valid_args___scaled_vector(Vector2D v, double d, Vector2D expected)
        {
            Vector2D actual = v * d;
            double delta = 0.00001;

            Assert.AreEqual(expected.U, actual.U, delta, "The U-component of the vector hasn't been computed correctly.");
            Assert.AreEqual(expected.V, actual.V, delta, "The V-component of the vector hasn't been computed correctly.");
        }

        /// <summary>
        /// Test of the the operator *(double, Vector2D)
        /// </summary>
        /// <param name="d">The real number</param>
        /// <param name="v">The Vector2D</param>
        /// <param name="expected">The expected result</param>
        [TestMethod]
        [DynamicData(nameof(Create_test_cases_for_multiplication_of_real_and_vector), DynamicDataSourceType.Method)]
        public void Vector2D_op_Multiplication_double_Vector2D___valid_args___scaled_vector(double d, Vector2D v, Vector2D expected)
        {
            Vector2D actual = d * v;
            double delta = 0.00001;

            Assert.AreEqual(expected.U, actual.U, delta, "The U-component of the vector hasn't been computed correctly.");
            Assert.AreEqual(expected.V, actual.V, delta, "The V-component of the vector hasn't been computed correctly.");
        }

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
        /// Creates test cases for the multiplication of a vector and a real number.
        /// </summary>
        /// <returns>Returns the test cases. Each test case contains the vector, the real number and the expected vector result.</returns>
        private static IEnumerable<object[]> Create_test_cases_for_multiplication_of_vector_and_real()
        {
            return new[]
            {
                new object[] { new Vector2D(0.0, 0.0), 0.0, new Vector2D(0.0, 0.0) },
                new object[] { new Vector2D(0.0, 0.0), -3.5, new Vector2D(0.0, 0.0) },
                new object[] { new Vector2D(2.0, 3.0), 2.1, new Vector2D(4.2, 6.3) },
                new object[] { new Vector2D(1.0, 2.0), -0.73, new Vector2D(-0.73, -1.46) },
                new object[] { new Vector2D(-3.4, 2.75), 22.415, new Vector2D(-76.211, 61.64125) },
                new object[] { new Vector2D(12.43, -2.754), 1023.56, new Vector2D(12722.8508, -2818.88424) },
                new object[] { new Vector2D(4.23, 6.81187), -13.25, new Vector2D(-56.0475, -90.2572775) },
                new object[] { new Vector2D(-17.4327, -8.1956), -0.45, new Vector2D(7.844715, 3.68802) }
            };
        }

        /// <summary>
        /// Creates test cases for the multiplication of a real number and a vector.
        /// </summary>
        /// <returns>Returns the test cases. Each test case contains the real number, the vector and the expected vector result.</returns>
        private static IEnumerable<object[]> Create_test_cases_for_multiplication_of_real_and_vector()
        {
            return new[]
            {
                new object[] { 0.0, new Vector2D(0.0, 0.0), new Vector2D(0.0, 0.0) },
                new object[] { -3.5, new Vector2D(0.0, 0.0), new Vector2D(0.0, 0.0) },
                new object[] { 2.1, new Vector2D(2.0, 3.0), new Vector2D(4.2, 6.3) },
                new object[] { -0.73, new Vector2D(1.0, 2.0), new Vector2D(-0.73, -1.46) },
                new object[] { 22.415, new Vector2D(-3.4, 2.75), new Vector2D(-76.211, 61.64125) },
                new object[] { 1023.56, new Vector2D(12.43, -2.754), new Vector2D(12722.8508, -2818.88424) },
                new object[] { -13.25, new Vector2D(4.23, 6.81187), new Vector2D(-56.0475, -90.2572775) },
                new object[] { -0.45, new Vector2D(-17.4327, -8.1956), new Vector2D(7.844715, 3.68802) }
            };
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
