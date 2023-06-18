namespace parsStudentPoints;

public interface IScoreParser
{
    List<LessonWithScore> parsScores(string data);
}