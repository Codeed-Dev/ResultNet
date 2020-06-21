using System.Collections.Generic;

namespace ResultNet
{
    public interface IResult
    {
        IEnumerable<string> Errors { get; }

        bool Succeeded { get; }

        bool Failed { get; }
    }
}
