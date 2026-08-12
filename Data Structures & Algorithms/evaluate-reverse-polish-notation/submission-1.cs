public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> oper = new();
        int a = 0;
        int b = 0;

        foreach(string token in tokens)
        {
            switch(token)
            {
                case "+":
                    b = oper.Pop();
                    a = oper.Pop();
                    oper.Push(a + b);
                break;

                case "-":
                    b = oper.Pop();
                    a = oper.Pop();
                    oper.Push(a - b);
                break;

                case "*":
                    b = oper.Pop();
                    a = oper.Pop();
                    oper.Push(a * b);
                break;

                case "/":
                    b = oper.Pop();
                    a = oper.Pop();
                    oper.Push(a / b);
                break;

                default:   
                    oper.Push(int.Parse(token));
                break;
            }
        }

        return oper.Peek();
    }
}

/*
["1","2","+","3","*","4","-"]

Loop through the array and store numbers in a stack until I get the operation

Stack:
1 - 2

2 + 1 = 3
Store in stack:
3 - 3

3 * 3 = 9

Store in stack
9 - 4

9 - 4 = 5

*/