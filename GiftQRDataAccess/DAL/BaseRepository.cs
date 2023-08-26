using GiftQRDataAccess.DAL.Contexts;
using GiftQRDataAccess.DAL.Interfaces;

namespace GiftQRDataAccess.DAL
{
    public class BaseRepository : IBaseRepository
    {
        protected UnitOfWork unitOfWork;

        protected GQRContext GQRContext
        {
            get
            {
                return unitOfWork.GQRContext;
            }
        }
    }
}
