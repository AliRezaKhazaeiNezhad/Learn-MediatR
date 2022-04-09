using MediatR;
using FluentResults;
using KhN.Server.Commands;

namespace KhN.Server.CommandHandlers
{
    public class DoSomeCode6CommandHandler : IRequestHandler<DoSomeCode6Command, Result<string>>
    {


        public async Task<Result<string>> Handle(DoSomeCode6Command request, CancellationToken cancellationToken)
        {
            var result = new Result<string>();

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
