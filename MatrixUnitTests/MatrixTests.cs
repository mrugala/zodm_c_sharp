using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZODMokienko;

namespace MatrixUnitTests
{
    [TestClass]
    public class MatrixUnitTest
    {
        private Matrix m3x3 = new Matrix(3, 3, new double[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } );
        private Matrix m4x3 = new Matrix(4, 3, new double[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
        private Matrix m3x5 = new Matrix(3, 5, new double[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });

        [TestMethod]
        public void CanCreateAnEmptyMatrix()
        {
            Matrix m = new Matrix(2, 2);
            Assert.IsTrue(m == new Matrix(2, 2, new double[4] { 0, 0, 0, 0 }) );
        }

        [TestMethod]
        public void CanReturnMatrixSize()
        {
            Assert.AreEqual(m3x3.getSize(), new Tuple<int, int>(3, 3));
        }

        [TestMethod]
        public void CanAccessSpecificCell()
        {
            Assert.AreEqual(m3x3[2,3], 6);
        }

        [TestMethod]
        public void CanAddMatrices()
        {
            Matrix m3x3n = m3x3 + m3x3;
            Assert.IsTrue(m3x3n == new Matrix(3, 3, new double[9] { 2, 4, 6, 
                                                                    8, 10, 12, 
                                                                    14, 16, 18 } ) );
        }

        [TestMethod]
        public void CanMultiplyMatricesOfSameSizes()
        {
            Matrix m3x3n = m3x3 * m3x3;
        }

        [TestMethod]
        public void CanMultiplyMatricesOfDifferentSizes()
        {
            Matrix m4x5 = m4x3 * m3x5;
            Assert.IsTrue(m4x5 == new Matrix(4, 5, new double[20] { 46,  52,  58,  64,  70, 
                                                                    100, 115, 130, 145, 160, 
                                                                    154, 178, 202, 226, 250,
                                                                    208, 241, 274, 307, 340 }) );
        }

        [TestMethod]
        [ExpectedException(typeof(Matrix.SizeMismatch))]
        public void WhenAddingMatricesOfDifferentSizes_ThrowsSizeMismatchError()
        {
            Matrix m3x3n = m3x3 + m4x3;
        }

        [TestMethod]
        [ExpectedException(typeof(Matrix.SizeMismatch))]
        public void WhenSizeMismatch_ThrowsSizeMismatchError()
        {
            Matrix m4x5 = m3x5 * m4x3;
        }

        [TestMethod]
        [ExpectedException(typeof(Matrix.SizeMismatch))]
        public void WhenCreatingMatrixInitializedWithDataOfWrongSize_ThrowsSizeMismatchError()
        {
            Matrix m = new Matrix(2, 2, new double[6]{ 1, 2, 3, 4, 5, 6 } );
        }
    }
}
