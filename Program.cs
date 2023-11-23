//generic queue; FIFO
var messages = new Queue<string>();

messages.Enqueue(".NET is Amazing");
messages.Enqueue("I wanna be the very best");
messages.Enqueue("The best there ever was");

while (messages.Count > 0)
{
    var message = messages.Dequeue();
    Console.WriteLine(message);
}