using System;

namespace Xgame.Domain.Entities
{
    public class ConsoleGame
    {
        public Guid  Id { get; set; }

        public Game Game { get; set; }

        public Console Console { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
