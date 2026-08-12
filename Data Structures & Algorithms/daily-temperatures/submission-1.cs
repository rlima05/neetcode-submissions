public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Stack<int[]> s = new();

        for(var i = 0; i < temperatures.Length; i++)
        {
            while(s.Count > 0 && s.Peek()[0] < temperatures[i])
            {
                var t = s.Pop();

                res[t[1]] = i- t[1]; 
            }

            s.Push(new int[] {temperatures[i], i});
        }

        return res;
    }
}
