using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LOAN_MANAGEMENT_API.Configuration;
using LOAN_MANAGEMENT_API.DTO;

namespace Namespace
{
    public class LoanPlanService : ILoanPlan
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public LoanPlanService(AppDBContext appDBContext, IMapper mapper)
        {
            _db = appDBContext;
            _mapper = mapper;
        }
        public List<LoanPlan> GetAll()
        {
            var data = _db.loanPlans!.ToList();
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public LoanPlan GetById(int id)
        {
            var data = _db.loanPlans!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public LoanPlan Create(LoanPlanDto req)
        {
            if (req != null)
            {
                var mapper = _mapper.Map<LoanPlan>(req);
                _db.loanPlans!.Add(mapper);
                _db.SaveChanges();
                return GetById(mapper.id);
            }
            return null!;
        }
        public LoanPlan Update(LoanPlanDto req)
        {
            if (req != null)
            {
                var mapper = _mapper.Map<LoanPlan>(req); 
                _db.loanPlans!.Update(mapper);
                _db.SaveChanges();
                 return GetById(mapper.id);
            }
            return null!;
        }
        public bool Remove(int id)
        {
            if (IsExist(id))
            {
                var ExistData = GetById(id);
                _db.loanPlans!.Remove(ExistData);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool IsExist(int id)
        {
            var data = _db.loanPlans!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return true;
            }
            return false;
        }
    }
}