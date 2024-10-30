using AutoMapper;
using LOAN_MANAGEMENT_API.Configuration;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Repository;
using Namespace;

namespace LOAN_MANAGEMENT_API.Service
{
    public class BorrowService : IBorrow
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public BorrowService(AppDBContext appDBContext, IMapper mapper)
        {
            _db = appDBContext;
            _mapper = mapper;
        }
        public List<Borrow> GetAll()
        {
            var data = _db.borrows!.ToList();
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public Borrow GetById(int id)
        {
            var data = _db.borrows!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public Borrow Create(BorrowDto req)
        {
            if (req != null)
            {
                var datamapper = _mapper.Map<Borrow>(req);
                _db.borrows!.Add(datamapper);
                _db.SaveChanges(); 
                return GetById(datamapper.id);
            }
            return null!;
        }
        public Borrow Update(BorrowDto req)
        {
            if (req!=null)
            {  
                var datamapper = _mapper.Map<Borrow>(req);
                _db.borrows!.Update(datamapper);
                _db.SaveChanges();
                return GetById(datamapper.id);
            }
            return null!;
        }
        public bool Remove(int id)
        {
            if (IsExist(id))
            {
                var ExistData = GetById(id);
                _db.borrows!.Remove(ExistData);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool IsExist(int id)
        {
            var data = _db.borrows!.FirstOrDefault(l => l.id == id);
            if (data != null)
            {
                return true;
            }
            return false;
        }
    }
}