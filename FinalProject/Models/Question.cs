namespace FinalProject.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
        public int CorrectAnswerIndex { get; set; } // Индекс правильного ответа
    }
}