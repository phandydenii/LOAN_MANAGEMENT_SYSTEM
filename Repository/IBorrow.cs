using LOAN_MANAGEMENT_API.DTO;
using Namespace;

namespace LOAN_MANAGEMENT_API.Repository
{
    public interface IBorrow
    {
        public List<Borrow>? GetAll();
        public Borrow GetById(int id);
        public Borrow Create(BorrowDto req);
        public Borrow Update(BorrowDto req);
        public bool Remove(int id);
        public bool IsExist(int id);
    }
}