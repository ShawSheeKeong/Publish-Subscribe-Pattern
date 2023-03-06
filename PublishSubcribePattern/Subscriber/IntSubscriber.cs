namespace PublishSubcribePattern.Subscriber
{
    public class IntSubscriber : ISubscriber
    {
        public void Print(object intObj)
        {
            if (intObj is int)
                Console.WriteLine($"The type is integer, output is {(int)intObj}");
        }
    }
}
