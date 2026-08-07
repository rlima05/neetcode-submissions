/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        
        int[] startDates = new int[intervals.Count];
        int[] endDates = new int[intervals.Count];

          for(var i = 0; i < intervals.Count; i++)
        {
            startDates[i] = intervals[i].start;
            endDates[i] = intervals[i].end;
        }

        Array.Sort(startDates); //0, 5, 15
        Array.Sort(endDates); //10, 20, 40

        int rooms = 0;
        int endIndex = 0;
        for(int startIndex = 0;  startIndex < intervals.Count; startIndex++)
        {
            if(startDates[startIndex] < endDates[endIndex]) //15 < 10? Yes
                rooms++; // 2
            else
                endIndex++; //1
        }

        return rooms;
        
    }
}