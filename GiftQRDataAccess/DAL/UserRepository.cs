using GiftQRDataAccess.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftQRDataAccess.DAL
{
    public class UserRepository : BaseRepository,IUserRepository
    {
        public UserRepository(UnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        }


    }
}
