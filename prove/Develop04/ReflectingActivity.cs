public class ReflectingActivity : Activity
{
    // string _userInputReflecting;

    private List<string> _startingMessage = new List<string>();
    private List<string> _relatedQuestion = new List<string>();


    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
        // main questions
        _startingMessage.Add("Think of a time when you stood up for someone else");
        _startingMessage.Add("Think of a time when you did something really difficult");
        _startingMessage.Add("Think of a time when you helped someone in need");
        _startingMessage.Add("Think of a time when you did something truly selfless");

        // related questions
        _relatedQuestion.Add("Why was this experience meaningful to you?");
        _relatedQuestion.Add("Have you ever done anything like this before?");
        _relatedQuestion.Add("How did you get started?");
        _relatedQuestion.Add("How did you feel when it was complete?");
        _relatedQuestion.Add("What made this time different than other times when you were not as successful?");
        _relatedQuestion.Add("What is your favorite thing about this experience?");
        _relatedQuestion.Add("What could you learn from this experience that applies to other situations?");
        _relatedQuestion.Add("What did you learn about yourself through this experience?");
        _relatedQuestion.Add("How can you keep this experience in mind in the future?");

    }

    public void Reflect()
    {
        Console.Clear();
        base.WelcomeMessage();
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        base.Animation(5);
        Console.Clear();
        Console.WriteLine("Consider the following prompt: \n");
        Thread.Sleep(500);

        // todo RANDOM QUESTION
        Random random = new Random();
        int startingMessageIndex = random.Next(0, _startingMessage.Count);
        string startingMessage = _startingMessage[startingMessageIndex];
        Console.WriteLine($"----- {startingMessage} -----\n");
        Thread.Sleep(5000);

        // this part will be the question for thought 
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.ReadLine();

        Console.Clear();
        Thread.Sleep(500);
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Thread.Sleep(500);

        Console.WriteLine("You may begin in:");
        base.Timer(5); //COUNT-DOWN TIMMER 
        Console.Clear();


        double loopTime = Math.Floor(Convert.ToDouble(base.getDuration() / (5)));
        for (double i = 1; i <= loopTime; i++)
        {
            int relatedQuestionIndex = random.Next(0, _relatedQuestion.Count);
            string relatedQuestion = _relatedQuestion[relatedQuestionIndex];
            Console.WriteLine($"\n{relatedQuestion}");
            base.Animation(5);
        }
        base.endingMessage();
    }

}
