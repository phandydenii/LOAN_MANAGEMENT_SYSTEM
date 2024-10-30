using LOAN_MANAGEMENT_API.DTO;
using Namespace;

namespace LOAN_MANAGEMENT_API.Repository
{
    public interface IPayment
    {
        public List<Payment>? GetAll();
        public Payment GetById(int id);
        public Payment Create(PaymentDto req);
        public Payment Update(PaymentDto req);
        public bool Remove(int id);
        public bool IsExist(int id);
    }
}