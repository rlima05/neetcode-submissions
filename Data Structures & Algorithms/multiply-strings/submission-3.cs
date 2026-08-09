public class Solution {
    public string Multiply(string num1, string num2) {
        if(num1 == "0") return "0";
        if(num2 == "0") return "0";

        int[] res = new int[num1.Length + num2.Length];
        num1 = new string(num1.Reverse().ToArray());
        num2 = new string(num2.Reverse().ToArray());

        for(var i1 = 0; i1 < num1.Length; i1++)
        {
            for(var i2 = 0; i2< num2.Length; i2++)
            {
                int digit = (num1[i1] - '0') * (num2[i2] - '0');
                res[i1+i2] += digit;
                res[i1+i2+1] += res[i1+i2] / 10;
                res[i1+i2] %= 10;
            }
        }

        Array.Reverse(res);
        int beginning = 0;

        while(beginning < res.Length && res[beginning] == 0)
            beginning++;

        string[] result = res.Skip(beginning).Select(x => x.ToString()).ToArray();

        return string.Join("", result);
    }
}
