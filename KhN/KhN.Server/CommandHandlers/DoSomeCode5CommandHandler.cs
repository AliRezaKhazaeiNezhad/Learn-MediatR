using MediatR;
using FluentResults;
using KhN.Server.Commands;

namespace KhN.Server.CommandHandlers
{
    public class DoSomeCode5CommandHandler : IRequestHandler<DoSomeCode5Command, Result>
    {


        public async Task<Result> Handle(DoSomeCode5Command request, CancellationToken cancellationToken)
        {
            Result result = new Result();

            try
            {
                string message = string.Empty;

                result.WithError("This is Errorrrrrrrrrr ... .");
                //result.WithSuccess("This is Successssssssssss ... .");
            }
            catch (Exception e)
            {
                result.WithError($"This is Errorrrrrrrrrr ... .{e.Message}");
            }

            return result;
        }
    }
}
