using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class PropertyGuestSeed
    {
        public static List<PropertyGuest> Data => new()
        {
            new PropertyGuest { PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", GuestTypeId = 1, GuestCount = 1 },
            new PropertyGuest { PropertyId = "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", GuestTypeId = 4, GuestCount = 5 },
            new PropertyGuest { PropertyId = "3e7f99ab-228a-4d90-91c4-6adf8c12e048", GuestTypeId = 1, GuestCount = 3 },
            new PropertyGuest { PropertyId = "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", GuestTypeId = 3, GuestCount = 1 },
            new PropertyGuest { PropertyId = "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", GuestTypeId = 2, GuestCount = 2 },
            new PropertyGuest { PropertyId = "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", GuestTypeId = 2, GuestCount = 6 },
            new PropertyGuest { PropertyId = "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", GuestTypeId = 4, GuestCount = 3 },
            new PropertyGuest { PropertyId = "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", GuestTypeId = 3, GuestCount = 2 }
        };
    }
}