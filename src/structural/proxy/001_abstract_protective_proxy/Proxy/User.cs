namespace Project
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Administrator,
        User
    }
}