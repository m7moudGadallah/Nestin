using Nestin.Core.Dtos.Countires;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class CountryMappingExtensions
    {
        public static CountryDto ToDo(this Country country)
        {
            return new CountryDto
            {
                Id = country.Id,
                Name = country.Name,
                RegionId = country.RegionId
            };
        }
    }
}
