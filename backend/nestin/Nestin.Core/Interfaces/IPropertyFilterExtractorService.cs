using Nestin.Core.Dtos.Properties;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyFilterExtractorService
    {
        Task<FilterPropertyQueryParamsDto> ExtractFiltersAsync(string naturalLanguageQuery);
    }
}
