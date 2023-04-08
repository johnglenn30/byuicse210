class SimpleGoal : Goals
{
    public override string Name => "Create Goals";
    public override string Description => "";
    public override void Start()
    {
        string fileName;
        string answer;

        Console.Write("Please create a filename(add .txt at the end) ");
        fileName = Console.ReadLine();

        Console.WriteLine("What is the name of title of your goal?  ");
        answer = Console.ReadLine();

        Console.WriteLine("How many points is this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());

        using (StreamWriter writer = File.AppendText(fileName))
        {
            writer.WriteLine(answer);
            writer.WriteLine(points);
        }

        Console.WriteLine("Your Current Goals are: \n");
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        Console.ReadLine();
    }

}
