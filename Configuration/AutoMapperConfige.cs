using AutoMapper;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Model;
using Namespace;

namespace LOAN_MANAGEMENT_API.Configuration
{
    public class AutoMapperConfige : Profile
    {
        public AutoMapperConfige()
        {
            CreateMap<Borrow,BorrowDto>().ReverseMap();
            CreateMap<Loan,LoanDto>().ReverseMap();
            CreateMap<LoanPlan,LoanPlanDto>().ReverseMap();
            CreateMap<LoanSchedule,LoanScheduleDto>().ReverseMap();
            CreateMap<LoanType,LoanTypeDto>().ReverseMap();
            CreateMap<Payment,PaymentDto>().ReverseMap();
        }
    }
}