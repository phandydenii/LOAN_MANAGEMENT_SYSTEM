using System;
using AutoMapper;
using LOAN_MANAGEMENT_API.Configuration;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Model;
using LOAN_MANAGEMENT_API.Repository;
using Microsoft.EntityFrameworkCore;

namespace LOAN_MANAGEMENT_API.Service
{
    public class LoanTypeService : ILoanType
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public LoanTypeService(AppDBContext appDBContext, IMapper mapper)
        {
            _db = appDBContext;
            _mapper = mapper;
        }
        public List<LoanType> GetAll()
        {
            var data = _db.loanTypes!.ToList();
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public LoanType GetById(int id)
        {
            var data = _db.loanTypes!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public LoanType Create(LoanTypeDto req)
        {
            if (req != null)
            {
                var data = _mapper.Map<LoanType>(req);
                _db.loanTypes!.Add(data);
                _db.SaveChanges();
                 return GetById(data.id);
            }
            return null!;
        }
        public LoanType Update(LoanTypeDto req)
        {
            if (req != null)
            { 
                var data = _mapper.Map<LoanType>(req);
                _db.loanTypes!.Update(data);
                _db.SaveChanges();
                 return GetById(data.id);
            }
            return null!;
        }
        public bool Remove(int id)
        {
            if (IsExist(id))
            {
                var ExistData = GetById(id);
                _db.loanTypes!.Remove(ExistData);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool IsExist(int id)
        {
            var data = _db.loanTypes!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return true;
            }
            return false;
        }
    }
}

