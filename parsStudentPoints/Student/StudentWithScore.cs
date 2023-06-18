namespace parsStudentPoints;


public class StudentWithScore
{
    public Student Student { get; set; }

    public List<LessonWithScore> lessons { get; set; }

    public StudentWithScore(Student student, List<LessonWithScore> lessons)
    {
        Student = student;
        this.lessons = lessons;
    }

    public StudentWithScore()
    {
    }
}