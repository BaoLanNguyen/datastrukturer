internal class Program
{
    private static void Main(string[] args)
    {
        string input = "[{}]";
        Stack<char> stack = new Stack<char>();
        foreach (char c in input)
        {
            if (c=='[' || c=='{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Unbalanced");
                    return;
                }
                bool b = false;
                char charStack = stack.Pop();
                if (c=='}' && charStack=='{')
                {
                    b = true;
                    
                }
                if (c==']' && charStack=='[')
                {
                    b = true;
                    
                }
                if (!b){
                    Console.WriteLine("Unbalanced");
                
                }
            }
        }
            
        if (stack.Count==0)
        {
            Console.WriteLine("Balanced");
        }
        else{
            Console.WriteLine("Unbalanced");
        }
        }
    }
