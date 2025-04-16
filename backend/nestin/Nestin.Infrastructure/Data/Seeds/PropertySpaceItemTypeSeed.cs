using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class PropertySpaceItemTypeSeed
    {
        public static List<PropertySpaceItemType> Data => new()
        {
            new PropertySpaceItemType {Id = 1, Name="Master Bedroom", PropertySpaceTypeId = 1},
            new PropertySpaceItemType {Id = 2, Name="Guest Bedroom", PropertySpaceTypeId = 1},
            new PropertySpaceItemType {Id = 3, Name="Kid’s Bedroom", PropertySpaceTypeId = 1},

            new PropertySpaceItemType {Id = 4, Name="Full Bathroom", PropertySpaceTypeId = 2},
            new PropertySpaceItemType {Id = 5, Name="Half Bathroom", PropertySpaceTypeId = 2},
            new PropertySpaceItemType {Id = 6, Name="Ensuite Bathroom", PropertySpaceTypeId = 2},

            new PropertySpaceItemType {Id = 7, Name="Full Kitchen", PropertySpaceTypeId = 3},
            new PropertySpaceItemType {Id = 8, Name="Kitchenette", PropertySpaceTypeId = 3},
            new PropertySpaceItemType {Id = 9, Name="Outdoor Kitchen", PropertySpaceTypeId = 3},

            new PropertySpaceItemType {Id = 10, Name="Living Room", PropertySpaceTypeId = 4},
            new PropertySpaceItemType {Id = 11, Name="Lounge Area", PropertySpaceTypeId = 4},
            new PropertySpaceItemType {Id = 12, Name="Entertainment Room", PropertySpaceTypeId = 4},

            new PropertySpaceItemType {Id = 13, Name="Dining Room", PropertySpaceTypeId = 5},
            new PropertySpaceItemType {Id = 14, Name="Breakfast Nook", PropertySpaceTypeId = 5},
            new PropertySpaceItemType {Id = 15, Name="Bar Counter", PropertySpaceTypeId = 5},

            new PropertySpaceItemType {Id = 16, Name="Dedicated Office", PropertySpaceTypeId = 6},
            new PropertySpaceItemType {Id = 17, Name="Desk in Room", PropertySpaceTypeId = 6},
            new PropertySpaceItemType {Id = 18, Name="Co-working Corner", PropertySpaceTypeId = 6},

            new PropertySpaceItemType {Id = 19, Name="Laundry Room", PropertySpaceTypeId = 7},
            new PropertySpaceItemType {Id = 20, Name="Washer/Dryer in Unit", PropertySpaceTypeId = 7},
            new PropertySpaceItemType {Id = 21, Name="Shared Laundry Area", PropertySpaceTypeId = 7},

            new PropertySpaceItemType {Id = 22, Name="Private Entrance", PropertySpaceTypeId = 8},
            new PropertySpaceItemType {Id = 23, Name="Shared Entrance", PropertySpaceTypeId = 8},
            new PropertySpaceItemType {Id = 24, Name="Gated Entrance", PropertySpaceTypeId = 8},

            new PropertySpaceItemType {Id = 25, Name="Balcony", PropertySpaceTypeId = 9},
            new PropertySpaceItemType {Id = 26, Name="Terrace", PropertySpaceTypeId = 9},
            new PropertySpaceItemType {Id = 27, Name="Rooftop", PropertySpaceTypeId = 9},

            new PropertySpaceItemType {Id = 28, Name="Backyard", PropertySpaceTypeId = 10},
            new PropertySpaceItemType {Id = 29, Name="Garden", PropertySpaceTypeId = 10},
            new PropertySpaceItemType {Id = 30, Name="Courtyard", PropertySpaceTypeId = 10},

            new PropertySpaceItemType {Id = 31, Name="Fire Pit", PropertySpaceTypeId = 11},
            new PropertySpaceItemType {Id = 32, Name="Indoor Fireplace", PropertySpaceTypeId = 11},
            new PropertySpaceItemType {Id = 33, Name="Outdoor Fireplace", PropertySpaceTypeId = 11},

            new PropertySpaceItemType {Id = 34, Name="Nursery", PropertySpaceTypeId = 12},
            new PropertySpaceItemType {Id = 35, Name="Changing Station", PropertySpaceTypeId = 12},
            new PropertySpaceItemType {Id = 36, Name="Crib Corner", PropertySpaceTypeId = 12},

            new PropertySpaceItemType {Id = 37, Name="Indoor Playroom", PropertySpaceTypeId = 13},
            new PropertySpaceItemType {Id = 38, Name="Outdoor Playset", PropertySpaceTypeId = 13},
            new PropertySpaceItemType {Id = 39, Name="Game Room", PropertySpaceTypeId = 13},

            new PropertySpaceItemType {Id = 40, Name="Walk-in Closet", PropertySpaceTypeId = 14},
            new PropertySpaceItemType {Id = 41, Name="Wardrobe", PropertySpaceTypeId = 14},
            new PropertySpaceItemType {Id = 42, Name="Luggage Storage", PropertySpaceTypeId = 14}
        };
    }
}
