using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOAN_MANAGEMENT_API.DTO;

namespace Namespace
{
    public interface ILoanPlan
    {
        public List<LoanPlan>? GetAll();
        public LoanPlan GetById(int id);
        public LoanPlan Create(LoanPlanDto req);
        public LoanPlan Update(LoanPlanDto req);
        public bool Remove(int id);
        public bool IsExist(int id);
    }
}