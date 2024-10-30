using AutoMapper;
using LOAN_MANAGEMENT_API.Configuration;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Repository;
using Namespace;

namespace LOAN_MANAGEMENT_API.Service
{
    public class LoanScheduleService : ILoanSchedule
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public LoanScheduleService(AppDBContext appDBContext,IMapper mapper)
        {
            _db = appDBContext;
            _mapper = mapper;
        }
        public List<LoanSchedule> GetAll()
        {
            var data = _db.loanSchedules!.ToList();
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public LoanSchedule GetById(int id)
        {
            var data = _db.loanSchedules!.FirstOrDefault(l => l.loan_schedule_id == id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }
        public LoanSchedule Create(LoanScheduleDto req)
        {
            if(req!=null){
                var mapper = _mapper.Map<LoanSchedule>(req);
                _db.loanSchedules!.Add(mapper);
                _db.SaveChanges();
                 return GetById(mapper.loan_schedule_id);
            }
            return null!;
        }
        public LoanSchedule Update(LoanScheduleDto req)
        {
           if(req!=null){
                var mapper = _mapper.Map<LoanSchedule>(req);
                _db.loanSchedules!.Update(mapper);
                _db.SaveChanges();
                 return GetById(mapper.loan_schedule_id);
            }
            return null!;
        }
        public bool Remove(int id)
        {
            if (IsExist(id))
            {
                var ExistData = GetById(id);
                _db.loanSchedules!.Remove(ExistData);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool IsExist(int id)
        {
            var data = _db.loanSchedules!.FirstOrDefault(l => l.loan_schedule_id == id);
            if (data != null)
            {
                return true;
            }
            return false;
        }
    }
}