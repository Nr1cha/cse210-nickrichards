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
        Console.WriteLine("Get ready...\n");
        Thread.Sleep(5000);
        Console.WriteLine("Consider the following prompt: \n");

        // todo RANDOM QUESTION
        Random random = new Random();
        int startingMessageIndex = random.Next(0, _startingMessage.Count);
        string startingMessage = _startingMessage[startingMessageIndex];
        Console.WriteLine($"----- {startingMessage} -----");
        Thread.Sleep(7000);

        // this part will be the question for thought 
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.ReadLine();

        // string userInput = Console.ReadLine();
        // todo Then check to see if they pressed enter
        Thread.Sleep(500);
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Thread.Sleep(500);

        Console.WriteLine("You may begin in:");
        base.Timer(5); //COUNT-DOWN TIMMER 
        Console.Clear();
        // todo RANDOM SUB-QUESTION
        int relatedQuestionIndex = random.Next(0, _relatedQuestion.Count);
        string relatedQuestion = _relatedQuestion[relatedQuestionIndex];
        Console.WriteLine($"\n{relatedQuestion}"); // SPINNING ANIMATION
        base.Animation(75);

        // wait for some time

        // todo RANDOM SUB-SUB-QUESTION
        int relatedQuestionIndex2 = random.Next(0, _relatedQuestion.Count);
        string relatedQuestion2 = _relatedQuestion[relatedQuestionIndex2];
        Console.WriteLine($"\n{relatedQuestion2}"); // SPINNING ANIMATION
        base.Animation(75);

        // wait for some time

        Console.WriteLine("\nWell done!!");
        // spin animation
        // end of activity
        Thread.Sleep(2000);
    }

}
