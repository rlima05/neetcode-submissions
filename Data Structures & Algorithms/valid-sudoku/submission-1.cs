public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> rows = new();
        Dictionary<int, HashSet<char>> cols = new();
        Dictionary<string, HashSet<char>> squares = new();

        for(var r = 0; r < 9; r++)
        {
            for(var c = 0; c < 9; c++)
            {
                if(board[r][c] == '.') continue;

                string squareKey = $"{(r/3)},{(c/3)}";

                char curr = board[r][c];

                if(rows.ContainsKey(r) && rows[r].Contains(curr)
                || cols.ContainsKey(c) && cols[c].Contains(curr)
                || squares.ContainsKey(squareKey) && squares[squareKey].Contains(curr))
                    return false;
                
                if(!rows.ContainsKey(r)) rows[r] = new();
                if(!cols.ContainsKey(c)) cols[c] = new();
                if(!squares.ContainsKey(squareKey)) squares[squareKey] = new();

                rows[r].Add(curr);
                cols[c].Add(curr);
                squares[squareKey].Add(curr);
            }
        }

        return true;
    }
}
