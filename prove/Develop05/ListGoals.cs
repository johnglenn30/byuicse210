class ListGoals : Goals
{
    public override string Name => "List Goals";
    public override string Description => "";
    public override void Start()
    {
        Console.WriteLine("Available .txt files:");
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{i+1}. {Path.GetFileName(files[i])}");
        }
        
        Console.Write("Enter the number of the file to display: ");
        int fileNumber;
        while (!int.TryParse(Console.ReadLine(), out fileNumber) || fileNumber < 1 || fileNumber > files.Length)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and {0}.", files.Length);
            Console.Write("Enter the number of the file to display: ");
        }

        Console.WriteLine("Your Current Goals are: \n");
        using (StreamReader reader = new StreamReader(files[fileNumber-1]))
        {
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        Console.ReadLine();
    }
}
