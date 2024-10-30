using System.Drawing;
using AutoMapper;
using LOAN_MANAGEMENT_API.Configuration;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Repository;
using Namespace;

namespace LOAN_MANAGEMENT_API.Service
{
    public class PaymentService : IPayment
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public PaymentService(AppDBContext appDBContext, IMapper mapper)
        {
            _db = appDBContext;
            _mapper = mapper;
        }
        public List<Payment> GetAll()
        {
            var data = _db.payments!.ToList();
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public Payment GetById(int id)
        {
            var data = _db.payments!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public Payment Create(PaymentDto req)
        {
            if (req != null)
            {
                var data = _mapper.Map<Payment>(req);
                _db.payments!.Add(data);
                _db.SaveChanges();
                return GetById(req.id);
            }
            return null!;
        }
        public Payment Update(PaymentDto req)
        {
            if (req != null)
            {
                var data = _mapper.Map<Payment>(req);
                _db.Update(data);
                _db.SaveChanges();
            }
            return null!;
        }
        public bool Remove(int id)
        {
            if (IsExist(id))
            {
                var ExistData = GetById(id);
                _db.payments!.Remove(ExistData);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool IsExist(int id)
        {
            var data = _db.payments!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return true;
            }
            return false;
        }
    }
}