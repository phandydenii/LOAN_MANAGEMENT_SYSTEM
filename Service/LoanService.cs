using System.Drawing;
using AutoMapper;
using LOAN_MANAGEMENT_API.Configuration;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Repository;
using Namespace;

namespace LOAN_MANAGEMENT_API.Service
{
    public class LoanService : ILoan
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public LoanService(AppDBContext appDBContext, IMapper mapper)
        {
            _db = appDBContext;
            _mapper = mapper;
        }
        public List<Loan> GetAll()
        {
            var data = _db.loans!.ToList();
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public Loan GetById(int id)
        {
            var data = _db.loans!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public Loan Create(LoanDto req)
        {
            if (req != null)
            {
                var data = _mapper.Map<Loan>(req);
                _db.loans!.Add(data);
                _db.SaveChanges();
                return GetById(req.id);
            }
            return null!;
        }
        public Loan Update(LoanDto req)
        {
              if (req != null)
            {
                var data = _mapper.Map<Loan>(req);
                _db.loans!.Update(data);
                _db.SaveChanges();
            }
            return null!;
        }
        public bool Remove(int id)
        {
            if (IsExist(id))
            {
                var ExistData = GetById(id);
                _db.loans!.Remove(ExistData);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool IsExist(int id)
        {
            var data = _db.loans!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return true;
            }
            return false;
        }
    }
}