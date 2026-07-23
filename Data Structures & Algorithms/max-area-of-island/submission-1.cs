public class Solution {
  
    private static readonly int[][] directions = new int[][] {
        new int[] {1, 0}, new int[] {-1, 0},
        new int[] {0, 1}, new int[] {0, -1}
    };

    public int MaxAreaOfIsland(int[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var maxNumber = 0;

        for(var r = 0; r < rows; r++)
        {
            for(var c = 0; c < cols; c++)
            {
                if(grid[r][c] == 1)
                    maxNumber = Math.Max(maxNumber, DFS(grid, r, c));
            }
        }

        return maxNumber;
    }

    private int DFS(int[][] grid, int r, int c)
    {
        if(r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length
        || grid[r][c] == 0)
            return 0;

        int res = 1;
        grid[r][c] = 0;

        foreach(var dir in directions)
        {
            res += DFS(grid, r + dir[0], c + dir[1]);
        }

        return res;
    }

    
}

/*
Loop through grid
    when find an island
        DFS and return the number of islands
        when it is not a 0, append 1 to number of islands
        sink the island (set to 0)

    Max(currentMax, newTotalfind)

*/