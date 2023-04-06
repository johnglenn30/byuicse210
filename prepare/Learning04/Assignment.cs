using System;

public class Assignment
{
    protected string studentName;
    protected string subject;

    public Assignment(string studentName, string subject)
    {
        this.studentName = studentName;
        this.subject = subject;
    }

    public string GetSummary()
    {
        return $"{studentName}'s assignment on {subject}";
    }
}