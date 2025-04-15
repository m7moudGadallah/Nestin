using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;
using Nestin.Infrastructure.Repositories;

namespace Nestin.Infrastructure.Shared
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private IRegionRepository? _regionRepository;
        private ICountryRepository? _countryRepository;
        private IPropertyRepository? _propertyRepository;
        private IPropertyTypeRepository? _propertyTypeRepository;
        private IAmenityRepository _amenityRepository;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRegionRepository RegionRepository => _regionRepository ??= new RegionRepository(_dbContext);
        public ICountryRepository CountryRepository => _countryRepository ??= new CountryRepository(_dbContext);
        public IPropertyRepository PropertyRepository => _propertyRepository ??= new PropertyRepository(_dbContext);
        public IPropertyTypeRepository PropertyTypeRepository => _propertyTypeRepository ??= new PropertyTypeRepository(_dbContext);
        public IAmenityRepository AmenityRepository => _amenityRepository ??= new AmenityRepository(_dbContext);
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
