public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Stack<int[]> stack = new Stack<int[]>(); //temp, index

        for(var i = 0; i < temperatures.Length; i++)
        {
            var t = temperatures[i];
            while(stack.Count > 0 && t > stack.Peek()[0])
            {
                var pair = stack.Pop();
                res[pair[1]] = i - pair[1];
            }

            stack.Push(new int[]{t, i});
        }

        return res;
    }
}

/*
brute force
for every temperature, loop through the other indexs till find a hotter day



*/