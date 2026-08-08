public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        bool[] rowZero = new bool[rows];
        bool[] colZero = new bool[cols];

        for(var r = 0; r < rows; r++)
        {
            for(var c = 0; c < cols; c++)
            {
                if(matrix[r][c] == 0)
                {
                    rowZero[r] = true;
                    colZero[c] = true;
                }
            }
        }

         for(var r = 0; r < rows; r++)
        {
            for(var c = 0; c < cols; c++)
            {
                if(rowZero[r] || colZero[c])
                    matrix[r][c] = 0;
            }
        }

    }
}
