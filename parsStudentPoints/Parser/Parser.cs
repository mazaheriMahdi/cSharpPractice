using System.Text.Json;

namespace parsStudentPoints;

public class Parser : IStudentParser , IScoreParser
{
    public List<Student> ParsStudent(string data)
    {
        var student = JsonSerializer.Deserialize<List<Student>>(data);
        return student as List<Student>;
    }

    public List<LessonWithScore> parsScores(string data)
    {
        var scores = JsonSerializer.Deserialize<List<LessonWithScore>>(data);
        return scores as List<LessonWithScore>;
    }
}