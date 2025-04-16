using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class PropertySpaceSeed
    {
        public static List<PropertySpace> Data => new()
        {
            new PropertySpace { Id = "3f95f420-21d6-4b2b-b2ef-4b2c92a7f2e9", Name = "Bedroom 1", PropertySpaceTypeId = 1, PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", IsShared = true },
            new PropertySpace { Id = "96ab72d9-2e0d-42d3-a5e3-1eaafc99b3c3", Name = "Bedroom 2", PropertySpaceTypeId = 1, PropertyId = "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", IsShared = false },
            new PropertySpace { Id = "f84c1d56-cdb4-4ac4-8a4e-1c7f4d1f32a7", Name = "Living Room 3", PropertySpaceTypeId = 4, PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", IsShared = true },
            new PropertySpace { Id = "6b631776-91e2-4b4c-bd37-cd82b9b4477d", Name = "Kitchen 1", PropertySpaceTypeId = 3, PropertyId = "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", IsShared = true },
            new PropertySpace { Id = "2450b4fc-b6b1-4b5e-a4e6-e9e297eeb8ff", Name = "Bathroom 1", PropertySpaceTypeId = 2, PropertyId = "3e7f99ab-228a-4d90-91c4-6adf8c12e048", IsShared = false },
            new PropertySpace { Id = "74f3f8db-0bfc-4c0b-b527-71a326e3f3e1", Name = "Balcony", PropertySpaceTypeId = 9, PropertyId = "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", IsShared = true },
            new PropertySpace { Id = "f65eb14d-4463-4fa9-a8c6-4b497e20d760", Name = "Dining Room", PropertySpaceTypeId = 5, PropertyId = "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", IsShared = true },
            new PropertySpace { Id = "0ea8ad1a-78d3-4e4a-831f-fb268e372338", Name = "Office", PropertySpaceTypeId = 6, PropertyId = "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", IsShared = false },
            new PropertySpace { Id = "c9f0d1e3-54a3-4f03-8b69-c11f3bdf02a6", Name = "Game Room", PropertySpaceTypeId = 14, PropertyId = "3e7f99ab-228a-4d90-91c4-6adf8c12e048", IsShared = true },
            new PropertySpace { Id = "6a61a1b1-27fd-4f3f-9d8a-9db0b2c35f5e", Name = "Storage", PropertySpaceTypeId = 16, PropertyId = "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", IsShared = false },
            new PropertySpace { Id = "e5dc74e1-d3c0-4878-8e9c-c4dc10fdbf0f", Name = "Library", PropertySpaceTypeId = 6, PropertyId = "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", IsShared = true },
            new PropertySpace { Id = "e1de9d5c-8232-44cc-9abf-9c9a1f0a5e0f", Name = "Gym", PropertySpaceTypeId = 6, PropertyId = "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", IsShared = true },
            new PropertySpace { Id = "b038b3db-c74d-4d2d-89a6-1ddf5c9580df", Name = "Bathroom 1", PropertySpaceTypeId = 2, PropertyId = "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", IsShared = false },
            new PropertySpace { Id = "961aa4f3-45dc-4933-a47b-cba57c1f726b", Name = "Laundry Room", PropertySpaceTypeId = 7, PropertyId = "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", IsShared = true },
            new PropertySpace { Id = "87e0c991-e32c-4e9c-a780-96f5567a9bb1", Name = "Kitchen 1", PropertySpaceTypeId = 3, PropertyId = "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", IsShared = false },
            new PropertySpace { Id = "ed9f2a7b-3e54-403e-b0ae-64ec33eec956", Name = "Bathroom 2", PropertySpaceTypeId = 2, PropertyId = "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", IsShared = false }
        };
    }
}