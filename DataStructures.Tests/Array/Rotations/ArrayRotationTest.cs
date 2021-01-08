using DataStructures.Array.Rotations;
using System;
using Xunit;

namespace DataStructures.Tests.Array.Rotations
{
    public class ArrayRotationTest
    {
        [Fact]
        public void RotateWithTempArrayTest()
        {
            // Arrange
            var sourceArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedByTwo = new int[] { 3, 4, 5, 6, 7, 1, 2 }; // with totalPositions: 2
            var expectedByThree = new int[] { 4, 5, 6, 7, 1, 2, 3 }; // with totalPositions: 3

            // Act & Assert
            Assert.Equal(sourceArray, ArrayRotation.RotateWithTempArray(sourceArray, totalPositions: 0));
            Assert.Equal(sourceArray, ArrayRotation.RotateWithTempArray(sourceArray, totalPositions: sourceArray.Length));
            
            Assert.Equal(expectedByTwo, ArrayRotation.RotateWithTempArray(sourceArray, totalPositions: 2));
            Assert.Equal(expectedByTwo, ArrayRotation.RotateWithTempArray(sourceArray, totalPositions: sourceArray.Length + 2));
            
            Assert.Equal(expectedByThree, ArrayRotation.RotateWithTempArray(sourceArray, totalPositions: 3));
            Assert.Equal(expectedByThree, ArrayRotation.RotateWithTempArray(sourceArray, totalPositions: sourceArray.Length + 3));
        }
    }
}
