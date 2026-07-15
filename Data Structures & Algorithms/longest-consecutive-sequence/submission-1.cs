public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        HashSet<int> set = new HashSet<int>(nums);
        int max = 0;

        foreach (int num in set) {
            if (!set.Contains(num - 1)) {
                int currentNumber = num;
                int currentCount = 1;

                while (set.Contains(currentNumber + 1)) {
                    currentNumber++;
                    currentCount++;
                }

                max = Math.Max(max, currentCount);
            }
        }

        return max;
    }
}