using MediatR;
using FluentResults;

namespace KhN.Server.Commands
{
    /// <summary>
    /// Command
    /// With Result
    /// ASync
    /// </summary>
    public class DoSomeCode6Command : IRequest<Result<string>>
    {
        public DoSomeCode6Command()
        {

        }


        public string SomeProperty { get; set; }
    }
}
