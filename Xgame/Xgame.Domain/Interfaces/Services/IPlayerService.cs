using System;
using Xgame.Domain.Arguments.Player;
using Xgame.Domain.ValueObjects;

namespace Xgame.Domain.Interfaces.Services
{
    public interface IPlayerService
    {
        string AuthenticatePlayer(string email, string password);

        AddPlayerResponse AddPlayer(AddPlayerRequest request);
    }
}
