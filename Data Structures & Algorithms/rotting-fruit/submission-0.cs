public class Solution {
    private static readonly int[][] directions = new int[][] {
        new int[] {1, 0}, new int[] {-1, 0},
        new int[] {0, 1}, new int[] {0, -1}
    };
    
    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int fresh = 0;
        int time = 0;

        Queue<int[]> q = new();

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == 1)
                    fresh++;
                else if(grid[r][c] == 2)
                    q.Enqueue(new int[] {r,c});
            }
        }



       while(fresh > 0 && q.Count > 0)
       {
         int length = q.Count;

         for(int i = 0; i < length; i++)
         {
            int[] curr = q.Dequeue();
            int r = curr[0];
            int c = curr[1];

            foreach(var dir in directions)
            {
                int row = r + dir[0];
                int col = c + dir[1];

                if(row >= 0 && row < rows &&
                    col >= 0 && col < cols &&
                    grid[row][col] == 1)
                    {
                        grid[row][col] = 2;
                        q.Enqueue(new int[] {row, col});
                        fresh--;
                    }
            }
         }

         time++; 
       }

       return fresh == 0? time : -1;
    }

    
}

/*
loop through the grid
when grid[r][c] == 2
    minutes = DFS through the grid

traverse again through the grid at the end
if any cell is still 1 return -1

otherwise minutes

DFS 
    transform current orage if fresh to rotten
    go to all directions
    for each successful cell I will go to next neibs add 1 to minutes



*/