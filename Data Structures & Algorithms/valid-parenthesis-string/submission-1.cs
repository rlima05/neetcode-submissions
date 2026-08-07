public class Solution {
    public bool CheckValidString(string s) {
        int leftMin = 0;
        int leftMax = 0;

        foreach(var c in s)
        {
            if(c == '(')
            {
                leftMax++;
                leftMin++;
            }
            else if(c == ')')
            {
                leftMin--;
                leftMax--;
            }
            else
            {
                leftMin--;
                leftMax++;
            }

            if(leftMax < 0)
                return false;
            if(leftMin < 0)
                leftMin = 0;
        }

        return leftMin == 0;
    }
}
