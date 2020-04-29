using Xgame.Domain.Interfaces.Arguments;
using Xgame.Domain.ValueObjects;

namespace Xgame.Domain.Arguments.Player
{
    public class AddPlayerRequest : IRequest
    {
        public Name Name { get; set; }

        public Email Email { get; set; }

        public string Password { get; set; }
    }
}
