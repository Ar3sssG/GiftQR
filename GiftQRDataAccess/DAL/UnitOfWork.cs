using GiftQRDataAccess.DAL.Contexts;
using GiftQRDataAccess.DAL.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace GiftQRDataAccess.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private IMemoryCache _memoryCache;

        public UnitOfWork(GQRContext dbContext,IMemoryCache memoryCache)
        {
            GQRContext = dbContext;
            _memoryCache = memoryCache;
        }
        public GQRContext GQRContext { get;}
        public IMemoryCache MemoryCache => _memoryCache;

        #region Repositories
        private IUserRepository userRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(this);
                }
                return userRepository;
            }
        }
        #endregion
    }
}
