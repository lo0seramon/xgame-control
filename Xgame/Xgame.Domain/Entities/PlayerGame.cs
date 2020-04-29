using System;

namespace Xgame.Domain.Entities
{
    class PlayerGame
    {
        public Guid Id { get; set; }

        public ConsoleGame ConsoleGame { get; set; }

        public bool IsWish { get; set; }

        public DateTime WishDate { get; set; }

        public bool IsTradeable { get; set; }

        public bool IsSale { get; set; }

    }
}
