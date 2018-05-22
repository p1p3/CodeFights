using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
   Note: Try to solve this task in-place (with O(1) additional memory), since this is what you'll be asked to do during an interview.
   
   You are given an n x n 2D matrix that represents an image. Rotate the image by 90 degrees (clockwise).
   
   Example
   
   For
   
   a = [[1, 2, 3],
   [4, 5, 6],
   [7, 8, 9]]
   the output should be
   
   rotateImage(a) =
   [[7, 4, 1],
   [8, 5, 2],
   [9, 6, 3]]
 */
namespace CodeFights.Solutions
{
    public class RotateImage
    {
        public static int[][] rotateImage(int[][] a)
        {
            var newMatrix = new int[a.Length][];
            var matrixSize = a.Length - 1;
            for (var rowIndex = 0; rowIndex < a.Length; rowIndex++)
            {
                newMatrix[rowIndex] = new int[a.Length];
                for (var columnIndex = 0; columnIndex < a.Length; columnIndex++)
                {
                    var newRowIndex = matrixSize - columnIndex;
                    var newColumnIndex = rowIndex;
                    newMatrix[rowIndex][columnIndex] = a[newRowIndex][newColumnIndex];
                }
            }
 
            return newMatrix.ToArray();

        }
    }
}
