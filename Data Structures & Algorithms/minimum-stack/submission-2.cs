public class MinStack {

    private Stack<int> s = new();
    private int min = int.MaxValue;
    private int max = int.MinValue;
    private Stack<int> minStack;
    
    public MinStack() {
         minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        s.Push(val);
        val = Math.Min(val, minStack.Count == 0 ? val : minStack.Peek());
        minStack.Push(val);

    }
    
    public void Pop() {
        s.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();        
    }
}
