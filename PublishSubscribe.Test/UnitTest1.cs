using PublishSubcribePattern;
using PublishSubcribePattern.Subscriber;

namespace PublishSubscribe.Test
{
    public class Tests
    {
        private Publisher Publisher;
        private StringWriter StringWriter;

        [SetUp]
        public void Setup()
        {
            Publisher = new Publisher();
            StringWriter = new StringWriter();
            Console.SetOut(StringWriter);
        }

        [Test]
        public void PublishWithMultiSubscribers_Test()
        {
            // Input Params
            DateTime sampleDateTime = DateTime.Now;

            Setup();

            var dateTimeSub1 = new DateTimeSubscriber();
            var dateTimeSub2 = new DateTimeSubscriber();

            Publisher.Subscribe(dateTimeSub1.Print);
            Publisher.Subscribe(dateTimeSub2.Print);
            Publisher.Start(sampleDateTime);

            var output = StringWriter.ToString();
            Assert.AreEqual($"The type is DateTime, output is {sampleDateTime}\r\nThe type is DateTime, output is {sampleDateTime}\r\n", output);
        }

        [Test]
        public void PublishWithMultiSubscribers_WithDiffTypes_Test()
        {
            // Input Params
            DateTime sampleDateTime = DateTime.Now;
            string sampleStr = "Input";

            Setup();

            var dateTimeSub = new DateTimeSubscriber();
            var strSub = new StringSubscriber();

            Publisher.Subscribe(dateTimeSub.Print);
            Publisher.Subscribe(strSub.Print);

            Publisher.Start(sampleDateTime);
            Publisher.Start(sampleStr);

            var output = StringWriter.ToString();
            Assert.AreEqual($"The type is DateTime, output is {sampleDateTime}\r\nThe type is string, output is {sampleStr}\r\n", output);
        }

        #region Different DataTypes
        [Test]
        public void PublishWithDateTime_Test()
        {
            // Input Params
            DateTime sampleDateTime = DateTime.Now;

            Setup();

            var dateTimeSub = new DateTimeSubscriber();

            Publisher.Subscribe(dateTimeSub.Print);
            Publisher.Start(sampleDateTime);

            var output = StringWriter.ToString();
            Assert.AreEqual($"The type is DateTime, output is {sampleDateTime}\r\n", output);
        }

        [Test]
        public void PublishWithInteger_Test()
        {
            // Input Params
            int sampleInt = 1000;

            Setup();

            var dateTimeSub = new IntSubscriber();

            Publisher.Subscribe(dateTimeSub.Print);
            Publisher.Start(sampleInt);

            var output = StringWriter.ToString();
            Assert.AreEqual($"The type is integer, output is {sampleInt}\r\n", output);
        }

        [Test]
        public void PublishWithString_Test()
        {
            // Input Params
            string sampleStr = "Input";

            Setup();

            var dateTimeSub = new StringSubscriber();

            Publisher.Subscribe(dateTimeSub.Print);
            Publisher.Start(sampleStr);

            var output = StringWriter.ToString();
            Assert.AreEqual($"The type is string, output is {sampleStr}\r\n", output);
        }
        #endregion
    }
}