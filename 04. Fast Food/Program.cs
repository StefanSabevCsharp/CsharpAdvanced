int quantity = int.Parse(Console.ReadLine());
int[] orders = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Queue<int> ordersQueue = new Queue<int>(orders);
Console.WriteLine(ordersQueue.Max());

while(ordersQueue.Any())
{
    
    int currentOrder = ordersQueue.Peek();
    if (quantity - currentOrder >= 0)
    {
        quantity -= currentOrder;
        ordersQueue.Dequeue();
    }
    else
    {
        break;
    }

}
if (ordersQueue.Any())
{
    Console.WriteLine($"Orders left: " + string.Join(" ",ordersQueue));
}
else
{
    Console.WriteLine("Orders complete");
}