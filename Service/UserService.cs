using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LOAN_MANAGEMENT_API.Configuration;
using LOAN_MANAGEMENT_API.Model;
using LOAN_MANAGEMENT_API.Model.Req;
using LOAN_MANAGEMENT_API.Model.Res;
using LOAN_MANAGEMENT_API.Repository;
using Microsoft.IdentityModel.Tokens;

namespace LOAN_MANAGEMENT_API.Service
{
    public class UserService : IUser
    {
        private readonly IConfiguration _configuration;
        private readonly AppDBContext _db;
        public UserService(IConfiguration configuration, AppDBContext db)
        {
            _configuration = configuration;
            _db = db;
        }

        public UserRes Login(UserLoginReq req)
        {
            UserRes res = new UserRes();
            var data = _db.users!.Where(x=>x.username==req.username && x.password==req.password).FirstOrDefault();
            if(data!=null){
                res.id=data.id;
                res.username=data.username;
                res.password = data.password;
                res.email = data.email;
                res.tokenid = generateJwtToken(req);
                return res;
            }
            return null!;
        }

        public User Register(User req)
        {
            if (req != null)
            { 
                _db.users!.Add(req);
                _db.SaveChanges();
                return _db.users.FirstOrDefault(x=>x.id==req.id)!;
            }
            return null!; 
        }


        private string generateJwtToken(UserLoginReq req)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(issuer: _configuration["Jwt:Issuer"],
                                                audience: _configuration["Jwt:Audience"],
                                                claims: new List<Claim>(), expires: DateTime.Now.AddDays(6),
                                                signingCredentials: signinCredentials);
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return tokenString;
        }
    }
}