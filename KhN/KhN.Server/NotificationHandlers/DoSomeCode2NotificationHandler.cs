using MediatR;
using System.Diagnostics;
using KhN.Server.Notifications;

namespace KhN.Server.NotificationHandlers
{
    public class DoSomeCode2NotificationHandler : INotificationHandler<DoSomeCodeNotification>
    {
        public DoSomeCode2NotificationHandler()
        {

        }

        public async Task Handle(DoSomeCodeNotification notification, CancellationToken cancellationToken)
        {
            await Task.Run(() => {
                string message = "This is notif 2";

                Console.WriteLine(message);
                Debug.WriteLine(message);
            });
        }
    }
}
