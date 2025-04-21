using Nestin.Core.Shared;

namespace Nestin.Core.Dtos.Properties
{
    public class PropertySearchResultDto : PaginatedResult<PropertyListItemDto>
    {
        public FilterPropertyQueryParamsDto SearchParams { get; set; }
    }
}
