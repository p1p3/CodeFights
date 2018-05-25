using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFights.Solutions
{
    public class Sudoku2
    {

        public static bool sudoku2(char[][] grid)
        {

            if (grid.Any(IsInvalid) || // across rows
                grid.Select((row, i) => i)
                    .Any(rowIndex => IsInvalid(grid.Select(_ => _[rowIndex])))) // down columns

                return false;

            // within sub-grids
            for (int r = 0; r < grid.Length; r += 3)
            {
                for (int c = 0; c < grid.Length; c += 3)
                {
                    if (IsInvalid(grid.Skip(r).Take(3).SelectMany(_ => _.Skip(c).Take(3))))
                        return false;
                }
            }
            return true;
        }

        static bool IsInvalid(IEnumerable<char> numbers)
        {
            var counts = new int[9];
            return numbers.Any(n => n != '.' && counts[n - '1']++ > 0);
        }

        private static bool MyMethod(char[][] grid)
        {
            var sudokuRows = new List<IEnumerable<char>>();
            var sudokuColumns = new Dictionary<int, List<char>>(grid.Length);
            var sudokuSubGrids = new Dictionary<int, List<char>>(grid.Length);

            for (var gridRowIndex = 0; gridRowIndex < grid.Length; gridRowIndex++)
            {

                var rowElements = new List<char>();
                for (var gridColumnIndex = 0; gridColumnIndex < grid.Length; gridColumnIndex++)
                {
                    var currentElement = grid[gridRowIndex][gridColumnIndex];
                    var isEmpty = currentElement == '.';
                    if (isEmpty) continue;

                    rowElements.Add(currentElement);

                    if (!sudokuColumns.ContainsKey(gridColumnIndex))
                    {
                        sudokuColumns.Add(gridColumnIndex, new List<char>());
                    }

                    sudokuColumns[gridColumnIndex].Add(currentElement);

                    var subGridIndex = GetSubGridIndex(gridRowIndex, gridColumnIndex, grid.Length - 1);
                    if (!sudokuSubGrids.ContainsKey(subGridIndex))
                    {
                        sudokuSubGrids.Add(subGridIndex, new List<char>());
                    }

                    sudokuSubGrids[subGridIndex].Add(currentElement);
                }

                sudokuRows.Add(rowElements);
            }

            foreach (var sudokuRow in sudokuRows)
            {
                var anyRepeatedRowElement = sudokuRow.GroupBy(element => element).Where(elements => elements.Count() > 1)
                    .ToList();

                if (anyRepeatedRowElement.Any()) return false;
            }


            foreach (var sudokuColumn in sudokuColumns)
            {
                var anyRepeatedColumnElement = sudokuColumn.Value.GroupBy(element => element).Where(elements => elements.Count() > 1)
                    .ToList();

                if (anyRepeatedColumnElement.Any()) return false;
            }

            foreach (var sudokuSubGrid in sudokuSubGrids)
            {
                var anyRepeatedGridElement = sudokuSubGrid.Value.GroupBy(element => element).Where(elements => elements.Count() > 1)
                    .ToList();

                if (anyRepeatedGridElement.Any()) return false;
            }


            return true;
        }

        private static int GetSubGridIndex(int rowIndex, int columnIndex, int gridSize)
        {
            var distanceFromColumnBorder = gridSize - columnIndex;
            var distanceFromRowBorder = gridSize - rowIndex;

            var isFirstSubGridRows = distanceFromRowBorder >= 6;
            var isFirstSubGridColumn = distanceFromColumnBorder >= 6;
            
            var isSecondSubGridColumn  = distanceFromColumnBorder >= 3 && distanceFromColumnBorder < 6;
            var isSecondSubGridRows = distanceFromRowBorder >= 3 && distanceFromRowBorder < 6;

            var isThirdSubGridRow = distanceFromRowBorder < 3;
            var isThirdSubGridColumn = distanceFromColumnBorder < 3;
            
            if (isFirstSubGridRows && isFirstSubGridColumn)
            {
                return 1;
            }
            else if (isFirstSubGridRows && isSecondSubGridColumn)
            {
                return 2;
            }
            else if (isFirstSubGridRows && isThirdSubGridColumn)
            {
                return 3;
            }
            else if (isSecondSubGridRows && isFirstSubGridColumn)
            {
                return 4;
            }
            else if (isSecondSubGridRows && isSecondSubGridColumn)
            {
                return 5;
            }
            else if (isSecondSubGridRows && isThirdSubGridColumn)
            {
                return 6;
            }
            else if (isThirdSubGridRow && isFirstSubGridColumn)
            {
                return 7;
            }
            else if (isThirdSubGridRow && isSecondSubGridColumn)
            {
                return 8;
            }
            else if (isThirdSubGridRow && isThirdSubGridColumn)
            {
                return 9;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}