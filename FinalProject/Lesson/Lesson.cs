namespace FinalProject.Lesson
{
    public class Lesson
    {
        public string Title { get; set; } = string.Empty; // Инициализация значением по умолчанию
        public string Content { get; set; } = string.Empty; // Инициализация значением по умолчанию
        public List<Question> Questions { get; set; } = new List<Question>(); // Инициализация списком
    }
        public class Question
    {
        public string Text { get; set; } = string.Empty;
        public List<string> Answers { get; set; } = new List<string>();
        public int CorrectAnswerIndex { get; set; } // Индекс правильного ответа
    }
}
