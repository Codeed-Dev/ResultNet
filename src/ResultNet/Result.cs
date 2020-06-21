using System;
using System.Threading.Tasks;

namespace ResultNet
{
    public class Result : Result<bool>
    {

        public static Result Try(Action action)
        {
            return Result.Try(() =>
            {
                action();
                return true;
            });
        }

        public static async Task<Result> TryAsync(Func<Task> action)
        {
            return await Result.TryAsync(async() =>
            {
                await action().ConfigureAwait(false);
                return true;
            }).ConfigureAwait(false);
        }

        public static Result Ok()
        {
            return new Result();
        }

        public Result()
        {

        }

        public Result(string errorMessage) : base(errorMessage)
        {

        }

        public override bool Value => this;

    }
}