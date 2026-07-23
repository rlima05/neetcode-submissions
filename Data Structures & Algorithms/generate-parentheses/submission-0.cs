public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> resp = new();
        var sb = new StringBuilder();
        Backtracking(0,0,n,resp, sb);

        return resp;

    }

    private void Backtracking(int closed, int open, int n, List<string> resp, StringBuilder stack)
    {
        if(closed == open && open == n)
        {
            resp.Add(stack.ToString());
            return;
        }

        if(open < n)
        {
            stack.Append("(");
            Backtracking(closed, open+1, n, resp, stack);
            stack.Length--;
        }
        if(closed < open)
        {
            stack.Append(")");
            Backtracking(closed+1, open, n, resp, stack);
            stack.Length--;
        }
    }
}

/*
Backtracking



*/