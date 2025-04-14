using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class GuestTypeSeed
    {
        public static List<GuestType> Data => new()
        {
            new GuestType {Id = 1, Name="Adults"},
            new GuestType {Id = 2, Name="Childern"},
            new GuestType {Id = 3, Name="Infants"},
            new GuestType {Id = 4, Name="Pets"}
        };
    }
}
