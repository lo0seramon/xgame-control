using Xgame.Domain.Interfaces.Arguments;
using Xgame.Domain.ValueObjects;

namespace Xgame.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse : IResponse
    {
        public Name Name { get; set; }

        public Email Email { get; set; }
    }
}
