using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class PropertyFeeSeed
    {
        public static List<PropertyFee> Data => new()
        {
            new PropertyFee { Id = 1, Name = "Cleaning Fee", PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", Amount = 1212.09m },
            new PropertyFee { Id = 2, Name = "Extra Guest Fee", PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", Amount = 442.09m },
            new PropertyFee { Id = 3, Name = "Pet Fee", PropertyId = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", Amount = 600m },
            new PropertyFee { Id = 4, Name = "Pet Fee", PropertyId = "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", Amount = 600m },
            new PropertyFee { Id = 5, Name = "Cleaning Fee", PropertyId = "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", Amount = 1200m },
            new PropertyFee { Id = 6, Name = "Cleaning Fee", PropertyId = "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", Amount = 900.12m },
            new PropertyFee { Id = 7, Name = "Extra Guest Fee", PropertyId = "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", Amount = 442.09m },
            new PropertyFee { Id = 8, Name = "Cleaning Fee", PropertyId = "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", Amount = 113.09m }
        };
    }
}