namespace parsStudentPoints;

public class Merger : IMergeStudentWithScores
{
    private IStudentParser _studentParser;
    private IScoreParser _scoreParser;

    public Merger()
    {
        _studentParser = new Parser();
        _scoreParser = new Parser();
    }
    
    public List<StudentWithScore> MergeStudentWithScores(string studentJson, string scoreJson)
    {
        List<Student> students = _studentParser.ParsStudent(studentJson);
        List<LessonWithScore> scores = _scoreParser.parsScores(scoreJson);
        List<StudentWithScore> studentWithScores = new List<StudentWithScore>();
        foreach (var student in students)
        {
            StudentWithScore studentWithScore = new StudentWithScore();
            studentWithScore.Student = student;
            studentWithScore.lessons  = scores.FindAll(score => score.StudentNumber == student.StudentNumber);
            studentWithScores.Add(studentWithScore);
        }

        return studentWithScores;
    }
}