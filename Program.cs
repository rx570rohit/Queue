
namespace Queue
{
    public class program
    {
        public static void Main(String[] args)
        {
            QueueByLL q = new QueueByLL();
            q.enqueue(56);
            q.enqueue(30);
            q.enqueue(70);
           
            Console.WriteLine("Queue Front : " + q.front.key);
            Console.WriteLine("Queue Rear : " + q.rear.key);
        }
    }
}