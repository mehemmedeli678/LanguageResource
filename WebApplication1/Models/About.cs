namespace WebApplication1.Models
{
    public class About
    {
        public int Id { get; set; }
        public string? Default { get; set; }
        public List<Aboutlanguage>? Aboutlanguages { get; set; }
    }
}
