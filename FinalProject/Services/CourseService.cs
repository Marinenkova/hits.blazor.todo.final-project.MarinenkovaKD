namespace FinalProject.Services;
using FinalProject.Models;
using System.Collections.Generic;
using System.Linq;

public class CourseService
{
    private List<Course> courses = new List<Course>
    {
        new Course
        {
            Id = 1,
            Title = "Основы C#",
            Description = "Изучение основ языка C#.",
            Lessons = new List<Lesson>
            {
                new Lesson
                {
                    Id = 1,
                    Title = "Введение в C#",
                    Content = "C# — это современный объектно-ориентированный язык программирования.",
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = 1,
                            Text = "Какой тип данных используется для хранения целых чисел?",
                            Answers = new List<string> { "int", "string", "bool" },
                            CorrectAnswerIndex = 0
                        },
                        new Question
                        {
                            Id = 2,
                            Text = "Какой метод используется для вывода текста на консоль?",
                            Answers = new List<string> { "Console.WriteLine()", "Print()", "Echo()" },
                            CorrectAnswerIndex = 0
                        }
                    }
                }
            }
        }
    };

    public List<Course> GetCourses() => courses;

    public Course GetCourse(int id) => courses.FirstOrDefault(c => c.Id == id);

    public Lesson GetLesson(int courseId, int lessonId)
    {
        var course = GetCourse(courseId);
        return course?.Lessons.FirstOrDefault(l => l.Id == lessonId);
    }

    public TestResult EvaluateTest(Lesson lesson, List<int> selectedAnswers)
    {
        int score = 0;
        for (int i = 0; i < lesson.Questions.Count; i++)
        {
            if (selectedAnswers[i] == lesson.Questions[i].CorrectAnswerIndex)
            {
                score++;
            }
        }
        return new TestResult { Score = score, TotalQuestions = lesson.Questions.Count };
    }
}
