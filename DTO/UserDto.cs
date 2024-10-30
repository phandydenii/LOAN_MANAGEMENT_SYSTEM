namespace LOAN_MANAGEMENT_API.DTO
{
    public class UserDto
    {
        
        public int id { get; set; } 
        public string? username { get; set; } 
        public string? password { get; set; } 
        public string? email { get; set; }
        public string? fullname { get; set; } 
        public DateTime dateadd { get; set; } 
        public DateTime expiredate { get; set; }
    }
}