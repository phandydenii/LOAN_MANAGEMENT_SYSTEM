using LOAN_MANAGEMENT_API.Configuration;
using LOAN_MANAGEMENT_API.DTO;
using Namespace;

namespace LOAN_MANAGEMENT_API.Repository
{
    public interface ILoan
    {
        public List<Loan>? GetAll();
        public Loan GetById(int id);
        public Loan Create(LoanDto req);
        public Loan Update(LoanDto req);
        public bool Remove(int id);
        public bool IsExist(int id);
    }
}