using MediatR;
using System.Diagnostics;
using KhN.Server.Notifications;

namespace KhN.Server.NotificationHandlers
{
    public class DoSomeCode1NotificationHandler : INotificationHandler<DoSomeCodeNotification>
    {
        public DoSomeCode1NotificationHandler()
        {

        }

        public async Task Handle(DoSomeCodeNotification notification, CancellationToken cancellationToken)
        {
            await Task.Run(() => {
                string message = "This is notif 1";

                Console.WriteLine(message);
                Debug.WriteLine(message);
            });
        }
    }
}
