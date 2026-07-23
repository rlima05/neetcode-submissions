public class Solution {

    private static readonly int[][] directions = new int[][] {
        new int[] {1, 0}, new int[] {-1, 0},
        new int[] {0, 1}, new int[] {0, -1}
    };

    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;

        for(var r = 0; r < rows; r++)
        {
         for(var c = 0; c < cols; c++)
         {
            if(grid[r][c] == '1')
            {   
                DFS(grid, r, c);
                islands++;
            }
         }
        }

        return islands;
    }


    private void DFS(char[][] grid, int r, int c)
    {
       if (r < 0 || c < 0 || r >= grid.Length ||
            c >= grid[0].Length || grid[r][c] == '0') {
            return;
        }

        grid[r][c] = '0';

        foreach(var dir in directions)
        {
            DFS(grid, r+ dir[0], c + dir[1]);
        }
    }
}
