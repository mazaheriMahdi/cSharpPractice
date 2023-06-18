using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace parsStudentPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            //get data from json files 
            string studentData = File.ReadAllText(
                "/Users/mahdimazaheri/RiderProjects/parsStudentPoints/parsStudentPoints/students.json");
            string scoreData =
                File.ReadAllText("/Users/mahdimazaheri/RiderProjects/parsStudentPoints/parsStudentPoints/scores.json");
            
            
            IMergeStudentWithScores mergeStudentWithScores = new Merger();
            List<StudentWithScore> studentWithScores =
                mergeStudentWithScores.MergeStudentWithScores(studentData, scoreData);

            IPrintStudentWithScore printStudentWithScore = new Printer();
            studentWithScores.ForEach(studentWithScore => { printStudentWithScore.PrintStudentWithScore(studentWithScore);});
            
        }
    }
};