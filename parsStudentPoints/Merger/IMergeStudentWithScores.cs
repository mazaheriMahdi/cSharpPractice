namespace parsStudentPoints;

public interface IMergeStudentWithScores
{
    public List<StudentWithScore> MergeStudentWithScores(string studentJson, string scoreJson);

}