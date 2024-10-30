using LOAN_MANAGEMENT_API.DTO;
using Namespace;

namespace LOAN_MANAGEMENT_API.Repository
{
    public interface ILoanSchedule
    {
         public List<LoanSchedule>? GetAll();
        public LoanSchedule GetById(int id);
        public LoanSchedule Create(LoanScheduleDto req);
        public LoanSchedule Update(LoanScheduleDto req);
        public bool Remove(int id);
        public bool IsExist(int id);
    }
}