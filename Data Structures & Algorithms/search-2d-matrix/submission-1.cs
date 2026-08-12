public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = 0;
        int lastColumn = matrix[0].Length-1;
        int up = 0;
        int bottom = matrix.Length - 1;

        while(up <= bottom)
        {
            int mid = (bottom + up) / 2;

            if(matrix[mid][0] <= target && matrix[mid][lastColumn] >= target)
            {
                row = mid;
                break;
            }
            else if(target > matrix[mid][lastColumn])
                up = mid+1;
            else
                bottom = mid-1;
        }

        int l = 0;
        int r = lastColumn;


        while(l <= r)
        {
            int mid = (l+r)/2;

            if(matrix[row][mid] == target)
                return true;
            else if(target > matrix[row][mid])
                l = mid+1;
            else
                r  = mid-1;
        }

        return false;
    }
}

/*
1 - 8
10-13
14-40

binary search on the rows 
    check mid row
    if target between index 0 and last of the row, that is correct
    otherwise if target > than last index left = mid + 1
    otherwise r = mid - 1

Then regular search in the row

*/