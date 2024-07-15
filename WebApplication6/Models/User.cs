namespace WebApplication6.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }
    }
}
