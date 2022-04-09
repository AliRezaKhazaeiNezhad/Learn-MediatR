using MediatR;

namespace KhN.Server.Commands
{
    /// <summary>
    /// Command
    /// Without Result
    /// Sync
    /// </summary>
    public class DoSomeCode1Command : IRequest
    {
        public DoSomeCode1Command()
        {

        }


        public string SomeProperty { get; set; }
    }
}
