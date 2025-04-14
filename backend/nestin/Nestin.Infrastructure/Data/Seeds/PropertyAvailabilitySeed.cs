using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class PropertyAvailabilitySeed
    {
        public static List<PropertyAvailability> Data => new()
        {
            new PropertyAvailability { Id = 1, StartDate = new DateTime(2025, 5, 2), EndDate = new DateTime(2025, 5, 6), PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
            new PropertyAvailability { Id = 2, StartDate = new DateTime(2025, 5, 10), EndDate = new DateTime(2025, 5, 16), PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
            new PropertyAvailability { Id = 3, StartDate = new DateTime(2025, 5, 22), EndDate = new DateTime(2025, 5, 30), PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
            new PropertyAvailability { Id = 4, StartDate = new DateTime(2025, 5, 2), EndDate = new DateTime(2025, 5, 5), PropertyId = "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" },
            new PropertyAvailability { Id = 5, StartDate = new DateTime(2025, 5, 10), EndDate = new DateTime(2025, 5, 12), PropertyId = "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" },
            new PropertyAvailability { Id = 6, StartDate = new DateTime(2025, 6, 22), EndDate = new DateTime(2025, 6, 30), PropertyId = "3e7f99ab-228a-4d90-91c4-6adf8c12e048" },
            new PropertyAvailability { Id = 7, StartDate = new DateTime(2025, 5, 2), EndDate = new DateTime(2025, 5, 6), PropertyId = "3e7f99ab-228a-4d90-91c4-6adf8c12e048" },
            new PropertyAvailability { Id = 8, StartDate = new DateTime(2025, 9, 10), EndDate = new DateTime(2025, 9, 16), PropertyId = "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" },
            new PropertyAvailability { Id = 9, StartDate = new DateTime(2025, 5, 22), EndDate = new DateTime(2025, 5, 30), PropertyId = "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" },
            new PropertyAvailability { Id = 10, StartDate = new DateTime(2025, 5, 2), EndDate = new DateTime(2025, 5, 6), PropertyId = "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" },
            new PropertyAvailability { Id = 11, StartDate = new DateTime(2025, 5, 10), EndDate = new DateTime(2025, 5, 16), PropertyId = "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" },
            new PropertyAvailability { Id = 12, StartDate = new DateTime(2025, 5, 22), EndDate = new DateTime(2025, 5, 30), PropertyId = "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" },
            new PropertyAvailability { Id = 13, StartDate = new DateTime(2025, 5, 22), EndDate = new DateTime(2025, 5, 25), PropertyId = "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" }
        };
    }
}