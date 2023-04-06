namespace PL.Models
{
    public class Usuario
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public Location Location { get; set; }
        public string Gender { get; set; }
        public Picture Picture { get; set; }
        public List<object> Usuarios { get; set; }
    }
}
