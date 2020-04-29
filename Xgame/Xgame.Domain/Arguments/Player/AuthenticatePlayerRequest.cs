using Xgame.Domain.Interfaces.Arguments;

namespace Xgame.Domain.Arguments.Player
{
    public class AuthenticatePlayerRequest : IRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
