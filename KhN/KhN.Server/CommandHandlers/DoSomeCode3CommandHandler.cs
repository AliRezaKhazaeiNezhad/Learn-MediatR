using MediatR;
using KhN.Server.Commands;

namespace KhN.Server.CommandHandlers
{
    public class DoSomeCode3CommandHandler : RequestHandler<DoSomeCode3Command, string>
    {
        public DoSomeCode3CommandHandler()
        {

        }

        protected override string Handle(DoSomeCode3Command request)
        {
            string message = request.SomeProperty.ToUpper();

            Console.WriteLine(message);
            System.Diagnostics.Debug.WriteLine(message);

            return message;
        }
    }
}
