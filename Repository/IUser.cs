using LOAN_MANAGEMENT_API.Model;
using LOAN_MANAGEMENT_API.Model.Req;
using LOAN_MANAGEMENT_API.Model.Res;

namespace LOAN_MANAGEMENT_API.Repository
{
    public interface IUser
    {
         public UserRes Login(UserLoginReq req);
         public User Register(User req);
    }
}