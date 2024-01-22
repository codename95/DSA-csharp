//Question 1: Implement a Stack with Push, Pop, and GetMin operations in O(1) time complexity.

  public class MinStack
{
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int x)
    {
        stack.Push(x);

        if (minStack.Count == 0 || x <= GetMin())
        {
            minStack.Push(x);
        }
    }

    public void Pop()
    {
        if (stack.Count > 0)
        {
            int popped = stack.Pop();

            if (popped == GetMin())
            {
                minStack.Pop();
            }
        }
    }

    public int Top()
    {
        return stack.Count > 0 ? stack.Peek() : -1;
    }

    public int GetMin()
    {
        return minStack.Count > 0 ? minStack.Peek() : -1;
    }
}
