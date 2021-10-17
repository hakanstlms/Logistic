using AutoMapper;
using HekaLojisticsApp.Business.Abstract.Company;
using HekaLojisticsApp.Business.Concrete.Base;
using HekaLojisticsApp.DataAccess.Concrete.UnitOfWork;

namespace HekaLojisticsApp.Business.Concrete.Company
{
    public class CompanyManager : ManagerBase, ICompanyService
    {

        public CompanyManager(IUnitOfWork unitOfWork,IMapper mapper) : base(unitOfWork,mapper)
        {

        }
         
    }
}
