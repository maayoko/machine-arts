namespace Machine_arts.Models 
{
    public class UserRegistration
    {
        public int Id { get; set; }
        public string? RegisterUsername { get; set; }
        public string? RegisterEmail { get; set; }
        public string? RegisterPassword { get; set; }
    }
}