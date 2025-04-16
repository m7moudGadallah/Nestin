using Nestin.Core.Dtos.AmenityCategories;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class AmenityCategoryMappingExtensions
    {
        public static AmenityCategoryDto ToDo(this AmenityCategory amenityCategory)
        {
            return new AmenityCategoryDto
            {
                Id = amenityCategory.Id,
                Name = amenityCategory.Name
            };
        }
    }
}
