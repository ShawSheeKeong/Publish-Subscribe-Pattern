namespace PublishSubcribePattern.Subscriber
{
    public class StringSubscriber : ISubscriber
    {
        public void Print(object stringObj)
        {
            if (stringObj is string)
                Console.WriteLine($"The type is string, output is {(string)stringObj}");
        }
    }
}
