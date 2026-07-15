public class MinStack {

    private Stack<int> mainStack;
    private Stack<int> minStack;
    
    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();    
    }
    
    public void Push(int val) {
        mainStack.Push(val);

        val = Math.Min(val, minStack.Count == 0? val: minStack.Peek());

        minStack.Push(val);
    }
    
    public void Pop() {
        mainStack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/*
Push -> stack push
pop -> stack pop
top -> stack peek

getmin
PriorityQueue 


*/