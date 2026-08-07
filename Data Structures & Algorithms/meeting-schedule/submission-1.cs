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
    public bool CanAttendMeetings(List<Interval> intervals) {

        intervals.Sort((i1, i2) => i1.start.CompareTo(i2.start));

        for(var i = 1; i < intervals.Count; i++)
        {
            if(intervals[i-1].end > intervals[i].start)
                return false;
        }

        return true;

    }
}

/*
end of previous interval is higher than start of current

loop through intervals from index 1 to end
if i - 1 end is higher than i start return false

*/