public class Solution {
    public void Rotate(int[][] matrix) {
        int left = 0;
        int right = matrix.Length - 1;

        while(left < right)
        {
            int limit = right-left;
            for(int i = 0; i < limit; i++)
            {
                int top = left;
                int bottom = right;

                int topLeft = matrix[top][left + i];

                matrix[top][left + i] = matrix[bottom - i][left];
                
                matrix[bottom - i][left] = matrix[bottom][right - i];

                matrix[bottom][right -i] = matrix[top + i][right];

                matrix[top + i][right] = topLeft;
            }

            left++;
            right--;
        }
    }
}


/*
[1,2]
[3,4]

[3,1]
[4,2]


*/