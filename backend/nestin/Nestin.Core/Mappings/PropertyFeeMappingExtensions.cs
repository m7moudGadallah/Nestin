using Nestin.Core.Dtos.PropertyFees;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class PropertyFeeMappingExtensions
    {
        public static PropertyFeeDto ToDto(this PropertyFee propertyFee)
        {
            return new PropertyFeeDto
            {
                Id = propertyFee.Id,
                Name = propertyFee.Name,
                Amount = propertyFee.Amount,
                PropertyId = propertyFee.PropertyId
            };
        }
    }
}
