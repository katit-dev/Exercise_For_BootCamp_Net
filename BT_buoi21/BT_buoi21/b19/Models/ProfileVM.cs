namespace b19.Models
{
    public class ProfileVM
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Summary { get; set; } = "";
        public List<string> SocialLinks { get; set; } = new();
    }
}