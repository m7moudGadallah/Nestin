using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class PropertySpaceItemSeed
    {
        public static List<PropertySpaceItem> Data => new()
        {
            new PropertySpaceItem { Id = 1, PropertySpaceItemTypeId = 2, PropertySpaceId = "3f95f420-21d6-4b2b-b2ef-4b2c92a7f2e9", Quantity = 1 },
            new PropertySpaceItem { Id = 2, PropertySpaceItemTypeId = 2, PropertySpaceId = "96ab72d9-2e0d-42d3-a5e3-1eaafc99b3c3", Quantity = 2 },
            new PropertySpaceItem { Id = 3, PropertySpaceItemTypeId = 10, PropertySpaceId = "f84c1d56-cdb4-4ac4-8a4e-1c7f4d1f32a7", Quantity = 1 },
            new PropertySpaceItem { Id = 4, PropertySpaceItemTypeId = 7, PropertySpaceId = "6b631776-91e2-4b4c-bd37-cd82b9b4477d", Quantity = 2 },
            new PropertySpaceItem { Id = 5, PropertySpaceItemTypeId = 4, PropertySpaceId = "2450b4fc-b6b1-4b5e-a4e6-e9e297eeb8ff", Quantity = 2 },
            new PropertySpaceItem { Id = 6, PropertySpaceItemTypeId = 25, PropertySpaceId = "74f3f8db-0bfc-4c0b-b527-71a326e3f3e1", Quantity = 2 },
            new PropertySpaceItem { Id = 7, PropertySpaceItemTypeId = 13, PropertySpaceId = "f65eb14d-4463-4fa9-a8c6-4b497e20d760", Quantity = 1 },
            new PropertySpaceItem { Id = 8, PropertySpaceItemTypeId = 16, PropertySpaceId = "0ea8ad1a-78d3-4e4a-831f-fb268e372338", Quantity = 1 },
            new PropertySpaceItem { Id = 9, PropertySpaceItemTypeId = 39, PropertySpaceId = "c9f0d1e3-54a3-4f03-8b69-c11f3bdf02a6", Quantity = 1 },
            new PropertySpaceItem { Id = 10, PropertySpaceItemTypeId = 42, PropertySpaceId = "6a61a1b1-27fd-4f3f-9d8a-9db0b2c35f5e", Quantity = 1 },
            new PropertySpaceItem { Id = 11, PropertySpaceItemTypeId = 18, PropertySpaceId = "e5dc74e1-d3c0-4878-8e9c-c4dc10fdbf0f", Quantity = 2 },
            new PropertySpaceItem { Id = 12, PropertySpaceItemTypeId = 12, PropertySpaceId = "e1de9d5c-8232-44cc-9abf-9c9a1f0a5e0f", Quantity = 1 },
            new PropertySpaceItem { Id = 13, PropertySpaceItemTypeId = 5, PropertySpaceId = "b038b3db-c74d-4d2d-89a6-1ddf5c9580df", Quantity = 1 },
            new PropertySpaceItem { Id = 14, PropertySpaceItemTypeId = 19, PropertySpaceId = "961aa4f3-45dc-4933-a47b-cba57c1f726b", Quantity = 3 },
            new PropertySpaceItem { Id = 15, PropertySpaceItemTypeId = 7, PropertySpaceId = "87e0c991-e32c-4e9c-a780-96f5567a9bb1", Quantity = 2 },
            new PropertySpaceItem { Id = 16, PropertySpaceItemTypeId = 6, PropertySpaceId = "ed9f2a7b-3e54-403e-b0ae-64ec33eec956", Quantity = 1 }
        };
    }
}