using MediatR;
using KhN.Server.Commands;

namespace KhN.Server.CommandHandlers
{
    public class DoSomeCode2CommandHandler : IRequestHandler<DoSomeCode2Command>
    {
        public DoSomeCode2CommandHandler()
        {

        }

        public async Task<Unit> Handle(DoSomeCode2Command request, CancellationToken cancellationToken)
        {
            await Task.Run(() => {
                string message = request.SomeProperty.ToUpper();

                Console.WriteLine(message);
                System.Diagnostics.Debug.WriteLine(message);
            });

            return new Unit();
        }
    }
}
