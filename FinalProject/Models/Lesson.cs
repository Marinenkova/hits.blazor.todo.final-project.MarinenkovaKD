namespace FinalProject.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}