public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = 0;
        int l = 0;
        int r = matrix.Length - 1;
        int n = matrix[0].Length;

        while(l <= r)
        {
            var mid = (r+l) / 2;

            if(target >= matrix[mid][0] && target <= matrix[mid][n-1])
            {
                row = mid;
                break;
            }
            else if(target <= matrix[mid][0])
                r = mid-1;
            else
                l = mid+1;
        }

        l = 0;
        r = n-1;

        while(l <= r)
        {
            var mid = (r+l)/2;
            if(matrix[row][mid] == target)
                return true;
            else if(target <= matrix[row][mid])
                r = mid-1;
            else
                l = mid+1;
        }

        return false;
    }
}

/*
Binary Search
First I need to find the right row
l = 0;
r = last row
mid = (r-l)/2
is target >= matrix[mid][0] && target <= matrix
    row = mid
    break;
else if(target <= matrix[mid][0])
    r = mid-1;
else 
    l = mid+1;

then binary search in the row
*/