namespace PublishSubcribePattern
{
    public class Publisher
    {
        private event ObjDelegate _objEvent;

        public void Subscribe(ObjDelegate objHandler)
        {
            _objEvent += objHandler;
        }

        public void Start(dynamic obj)
        {
            if (_objEvent != null)
                _objEvent(obj);
        }
    }
}
