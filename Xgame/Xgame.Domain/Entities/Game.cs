using System;

namespace Xgame.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string DistributionCompany { get; set; }

        public string ProductionCompany { get; set; }

        public string Genre { get; set; }

        public string OfficialSite { get; set; }
    }
}
