namespace PublishSubcribePattern.Subscriber
{
    public class DateTimeSubscriber : ISubscriber
    {
        public void Print(object dateTimeObj) 
        {
            if (dateTimeObj is DateTime)
                Console.WriteLine($"The type is DateTime, output is {(DateTime)dateTimeObj}");
        }
    }
}
