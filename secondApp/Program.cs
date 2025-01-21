// See https://aka.ms/new-console-template for more information

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);



Console.WriteLine("\nStack:");  
foreach (var item in stack)
{
    Console.WriteLine(item);
}