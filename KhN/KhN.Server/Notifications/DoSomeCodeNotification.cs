using MediatR;

namespace KhN.Server.Notifications
{
    public class DoSomeCodeNotification : INotification
    {
        public DoSomeCodeNotification() : base()
        {

        }

        public string SomeProperty { get; set; }
    }
}
