namespace LOAN_MANAGEMENT_API.Model.Res
{
    public class UserRes
    {
        public int id { get; set; } 
        public string? username { get; set; } 
        public string? password { get; set; } 
        public string? email { get; set; } 
        public string? tokenid { get; set; }
    }
}