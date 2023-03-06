using PublishSubcribePattern;
using PublishSubcribePattern.Subscriber;

var publisher = new Publisher();

var strSub = new StringSubscriber();
var dateTimeSub = new DateTimeSubscriber();

publisher.Subscribe(strSub.Print);
publisher.Subscribe(dateTimeSub.Print);

publisher.Start(DateTime.Now);