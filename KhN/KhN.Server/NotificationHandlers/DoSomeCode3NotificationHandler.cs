using MediatR;
using System.Diagnostics;
using KhN.Server.Notifications;

namespace KhN.Server.NotificationHandlers
{
    public class DoSomeCode3NotificationHandler : INotificationHandler<DoSomeCodeNotification>
    {
        public DoSomeCode3NotificationHandler()
        {

        }

        public async Task Handle(DoSomeCodeNotification notification, CancellationToken cancellationToken)
        {
            await Task.Run(() => {
                string message = "This is notif 3";

                Console.WriteLine(message);
                Debug.WriteLine(message);
            });
        }
    }
}
