using DataStructures.Array.Rotations;
using System;
using Xunit;

namespace DataStructures.Tests.Array.Rotations
{
    public class ArrayRotationTest
    {
        [Fact]
        public void GetRotatedArrayWithTempArrayTest()
        {
            // Arrange
            var sourceArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedByTwo = new int[] { 3, 4, 5, 6, 7, 1, 2 }; // with totalPositions: 2
            var expectedByFive = new int[] { 6, 7, 1, 2, 3, 4, 5 }; // with totalPositions: 5

            // Act & Assert
            Assert.Equal(sourceArray, ArrayRotation.GetRotatedArrayWithTempArray(sourceArray, totalPositions: 0));
            Assert.Equal(sourceArray, ArrayRotation.GetRotatedArrayWithTempArray(sourceArray, totalPositions: sourceArray.Length));
            
            Assert.Equal(expectedByTwo, ArrayRotation.GetRotatedArrayWithTempArray(sourceArray, totalPositions: 2));
            Assert.Equal(expectedByTwo, ArrayRotation.GetRotatedArrayWithTempArray(sourceArray, totalPositions: sourceArray.Length + 2));
            
            Assert.Equal(expectedByFive, ArrayRotation.GetRotatedArrayWithTempArray(sourceArray, totalPositions: 5));
            Assert.Equal(expectedByFive, ArrayRotation.GetRotatedArrayWithTempArray(sourceArray, totalPositions: sourceArray.Length + 5));

            var arrayByTwo = sourceArray.Clone() as int[];
            ArrayRotation.LeftRotateArray(arrayByTwo, rotation: 2);
            Assert.Equal(expectedByTwo, arrayByTwo);

            var arrayByLengthAndTwo = sourceArray.Clone() as int[];
            ArrayRotation.LeftRotateArray(arrayByLengthAndTwo, rotation: sourceArray.Length + 2);
            Assert.Equal(expectedByTwo, arrayByLengthAndTwo);

            var arrayByFive = sourceArray.Clone() as int[];
            ArrayRotation.LeftRotateArray(arrayByFive, rotation: 5);
            Assert.Equal(expectedByFive, arrayByFive);
        }
    }
}
