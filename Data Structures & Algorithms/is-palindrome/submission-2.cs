public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length -1;
        s = s.ToLower();
        while(l < r)
        {
            while(l < r && !IsValid(s[l])) l++;
            while(l < r && !IsValid(s[r])) r--;

            if(s[l] != s[r]) return false;

            l++;
            r--;
        }

        return true;
    }

    private bool IsValid(char c)
    {
        if(char.IsNumber(c) || char.IsLetter(c)) return true;

        return false;
    }
}

/*
Two points
    l = 0
    r last char 
    compare boths when they are valid chars (numbers, a-z, A-Z)
    if there is any difference return false
    otherwise move l to the right one position and r left one position
    repeat until they meet

O(n) -> O(1);



*/