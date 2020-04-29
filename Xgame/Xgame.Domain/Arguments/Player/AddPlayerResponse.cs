using System;
using Xgame.Domain.Interfaces.Arguments;

namespace Xgame.Domain.Arguments.Player
{
    public class AddPlayerResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
