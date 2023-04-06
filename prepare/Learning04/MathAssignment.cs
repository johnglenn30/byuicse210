public class MathAssignment : Assignment
{
    private string problems;

    public MathAssignment(string studentName, string subject, string problems) : base(studentName, subject)
    {
        this.problems = problems;
    }

    public string GetHomeworkList()
    {
        return problems;
    }
}