using MediatR;
using KhN.Server.Commands;

namespace KhN.Server.CommandHandlers
{
    public class DoSomeCode4CommandHandler : IRequestHandler<DoSomeCode4Command, string>
    {
        public DoSomeCode4CommandHandler()
        {

        }

        public async Task<string> Handle(DoSomeCode4Command request, CancellationToken cancellationToken)
        {
            string message = string.Empty;

            await Task.Run(() => {
                message = request.SomeProperty.ToUpper();

                Console.WriteLine(message);
                System.Diagnostics.Debug.WriteLine(message);
            });

            return message;
        }
    }
}
