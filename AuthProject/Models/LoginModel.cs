namespace AuthProject.Models
{
    public class LoginModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public bool KeepLoggedIn { get; set; }
        public string Password { get; set; }    
    }
}
