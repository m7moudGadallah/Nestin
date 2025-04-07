using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Nestin.Api.Utils
{
    public static class ModelStateDictionaryExtensions
    {
        public static List<string> ExtractErrorList(this ModelStateDictionary model)
        {
            return model.Where(kv => kv.Value.Errors.Any()) // Only include fields with errors
                .SelectMany(kv => kv.Value.Errors.Select(e => e.ErrorMessage)) // Extract error messages
                .ToList();
        }
    }
}
