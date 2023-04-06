public class WritingAssignment : Assignment
{
    private string words;

    public WritingAssignment(string studentName, string subject, string words) : base(studentName, subject) 
    {
        this.words = words;
    }

    public string GetWritingInfo()
    {
        return $"{base.GetSummary()} create an essay on {words}";
    }
}