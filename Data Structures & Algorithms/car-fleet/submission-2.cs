public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pairs = new int[position.Length][];

        for(var i = 0; i < position.Length; i++)
        {
            pairs[i] = new int[] {position[i], speed[i]};
        }

        Stack<double> stack = new();

        Array.Sort(pairs, (a,b) => b[0].CompareTo(a[0]));

        foreach(var pair in pairs)
        {
            double calc = (double)(target - pair[0]) / pair[1];
            stack.Push(calc);
            if(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
                stack.Pop();

        }


        return stack.Count;
    }
}
