using MediatR;

namespace KhN.Server.Commands
{
    /// <summary>
    /// Command
    /// Without Result
    /// Sync
    /// </summary>
    public class DoSomeCode3Command : IRequest<string>
    {
        public DoSomeCode3Command()
        {

        }


        public string SomeProperty { get; set; }
    }
}
