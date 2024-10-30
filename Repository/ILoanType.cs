using System;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Model;

namespace LOAN_MANAGEMENT_API.Repository
{
	public interface ILoanType
    {
		public List<LoanType>? GetAll();
        public LoanType GetById(int id);
        public LoanType Create(LoanTypeDto req);
        public LoanType Update(LoanTypeDto req);
        public bool Remove(int id);
        public bool IsExist(int id);
    }
}

