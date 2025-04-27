using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyPhotoRepository : IBaseRepository
    {
        public Task<IReadOnlyCollection<PropertyPhoto>> GetAllByPropertyIdASync(string propertyId);
        public void Create(PropertyPhoto entity);
        public void Update(PropertyPhoto entity);
    }
}
