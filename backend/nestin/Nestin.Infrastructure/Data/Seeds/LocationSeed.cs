using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class LocationSeed
    {
        public static List<Location> Data => new()
        {
            new Location { Id = 1, Name = "Nazlet El-Semman, Giza Governorate", CountryId = 64 },
            new Location { Id = 2, Name = "Milan, Lombardia", CountryId = 106 },
            new Location { Id = 3, Name = "Makkah, Makkah Province", CountryId = 191 },
            new Location { Id = 4, Name = "Yucca Valley, California", CountryId = 231 },
            new Location { Id = 5, Name = "Salvador, Bahia", CountryId = 31 },
            new Location { Id = 6, Name = "Barcelona, Catalunya", CountryId = 205 },
            new Location { Id = 7, Name = "Wadi Rum Village, Aqaba Governorate", CountryId = 110 },
            new Location { Id = 8, Name = "Tanneron, Provence-Alpes-Côte d'Azur", CountryId = 74 }
        };
    }
}
