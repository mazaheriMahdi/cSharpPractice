namespace parsStudentPoints;

public class Printer : IPrintStudentWithScore
{
    public void PrintStudentWithScore(StudentWithScore studentWithScore)
    {
        Student student = studentWithScore.Student;
        Console.WriteLine(student.StudentNumber + "-" + student.FirstName + " " + student.LastName);
        studentWithScore.lessons.ForEach(score =>
        {
            Console.WriteLine("\t" + score.Lesson + " = " + score.Score);
        });
    }
}