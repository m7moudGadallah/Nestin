using Nestin.Core.Dtos.GuestTypes;

namespace Nestin.Core.Dtos.PropertyGuests
{
    public class PropertyGuestsDto
    {
        public string PropertyId { get; set; }
        public GuestTypesDto GuestType { get; set; }
        public int GuestCount { get; set; }
    }
}
