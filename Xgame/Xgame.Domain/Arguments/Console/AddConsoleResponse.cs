using System;
using Xgame.Domain.Interfaces.Arguments;

namespace Xgame.Domain.Arguments.Console
{
    public class AddConsoleResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }
    }
}
