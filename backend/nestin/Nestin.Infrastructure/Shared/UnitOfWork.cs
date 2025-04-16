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
        private IAmenityRepository? _amenityRepository;
        private IAmenityCategoryRepository? _amenityCategoryRepository;
        private IGuestTypeReposiotry? _guestTypeReposiotry;
        private IPropertyAmenityRepository? _propertyAmenityRepository;
        private IPropertyGuestRepository? _propertyGuestRepository;
        private IPropertySpaceTypeRepository? _propertySpaceTypeRepository;
        private IPropertySpaceItemTypeRepository _propertySpaceItemTypeRepository;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRegionRepository RegionRepository => _regionRepository ??= new RegionRepository(_dbContext);
        public ICountryRepository CountryRepository => _countryRepository ??= new CountryRepository(_dbContext);
        public IPropertyRepository PropertyRepository => _propertyRepository ??= new PropertyRepository(_dbContext);
        public IPropertyTypeRepository PropertyTypeRepository => _propertyTypeRepository ??= new PropertyTypeRepository(_dbContext);
        public IAmenityRepository AmenityRepository => _amenityRepository ??= new AmenityRepository(_dbContext);
        public IAmenityCategoryRepository AmenityCategoryRepository => _amenityCategoryRepository ??= new AmenityCategoryRepository(_dbContext);
        public IGuestTypeReposiotry GuestTypeReposiotry => _guestTypeReposiotry ??= new GuestTypeRepository(_dbContext);
        public IPropertyAmenityRepository PropertyAmenityRepository => _propertyAmenityRepository ??= new PropertyAmenityRepository(_dbContext);
        public IPropertyGuestRepository PropertyGuestRepository => _propertyGuestRepository ??= new PropertyGuestRepository(_dbContext);
        public IPropertySpaceTypeRepository PropertySpaceTypeRepository => _propertySpaceTypeRepository ??= new PropertySpaceTypeRepository(_dbContext);
        public IPropertySpaceItemTypeRepository PropertySpaceItemTypeRepository => _propertySpaceItemTypeRepository ??= new PropertySpaceItemTypeRepository(_dbContext);
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
