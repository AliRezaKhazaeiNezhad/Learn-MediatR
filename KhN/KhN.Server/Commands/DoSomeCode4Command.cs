using MediatR;

namespace KhN.Server.Commands
{
    /// <summary>
    /// Command
    /// With Result
    /// ASync
    /// </summary>
    public class DoSomeCode4Command : IRequest<string>
    {
        public DoSomeCode4Command()
        {

        }


        public string SomeProperty { get; set; }
    }
}
