using System;

namespace Xgame.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
