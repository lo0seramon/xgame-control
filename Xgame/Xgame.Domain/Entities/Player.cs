using System;
using Xgame.Domain.Enums;
using Xgame.Domain.ValueObjects;

namespace Xgame.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; set; }

        public Name Name { get; set; }

        public Email Email { get; set; }

        public string Password { get; set; }

        public EnumPlayerStatus Status { get; set; }

    }
}
