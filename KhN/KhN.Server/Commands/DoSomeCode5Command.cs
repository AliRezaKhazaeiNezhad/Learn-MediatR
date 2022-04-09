using MediatR;
using FluentResults;

namespace KhN.Server.Commands
{
    /// <summary>
    /// Command
    /// With Result
    /// ASync
    /// </summary>
    public class DoSomeCode5Command : IRequest<Result>
    {
        public DoSomeCode5Command()
        {

        }


        public string SomeProperty { get; set; }
    }
}
