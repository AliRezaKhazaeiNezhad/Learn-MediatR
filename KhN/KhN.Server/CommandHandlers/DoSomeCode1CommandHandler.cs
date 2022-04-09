using MediatR;
using KhN.Server.Commands;

namespace KhN.Server.CommandHandlers
{
    public class DoSomeCode1CommandHandler : RequestHandler<DoSomeCode1Command>
    {
        public DoSomeCode1CommandHandler()
        {

        }

        protected override void Handle(DoSomeCode1Command request)
        {
            string message = request.SomeProperty.ToUpper();
            Console.WriteLine(message);

            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
