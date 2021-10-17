using AutoMapper;
using HekaLojisticsApp.DataAccess.Concrete.UnitOfWork;

namespace HekaLojisticsApp.Business.Concrete.Base
{
    public   class ManagerBase
    {
        public ManagerBase(IUnitOfWork unitOfWork, IMapper mapper)
        {

            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        protected IUnitOfWork UnitOfWork { get; }
        protected IMapper Mapper { get; }

    }
}
