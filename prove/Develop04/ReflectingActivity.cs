public class ReflectingActivity : Activity
{
    string _userInputReflecting;

    private List<string> _startingMessage = new List<string>();
    private List<string> _relatedQuestions = new List<string>();

    
    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
        // main questions
        _startingMessage.Add("Think of a time when you stood up for someone else");
        _startingMessage.Add("Think of a time when you did something really difficult");
        _startingMessage.Add("Think of a time when you helped someone in need");
        _startingMessage.Add("Think of a time when you did something truly selfless");

        // related questions
        _relatedQuestions.Add("Why was this experience meaningful to you?");
        _relatedQuestions.Add("Have you ever done anything like this before?");
        _relatedQuestions.Add("How did you get started?");
        _relatedQuestions.Add("How did you feel when it was complete?");
        _relatedQuestions.Add("What made this time different than other times when you were not as successful?");
        _relatedQuestions.Add("What is your favorite thing about this experience?");
        _relatedQuestions.Add("What could you learn from this experience that applies to other situations?");
        _relatedQuestions.Add("What did you learn about yourself through this experience?");
        _relatedQuestions.Add("How can you keep this experience in mind in the future?");
        
    }

    public void Reflect()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine("Consider the following prompt: ");
        // RANDOM QUESTION
        // this part will be the question for thought 
        Console.WriteLine("When you have something in mind, press enter to continue.");
        // ENTER
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in:"); //COUNT-DOWN TIMMER 
        Console.Clear();
        // RANDOM SUB-QUESTION
        Console.WriteLine("How did you feel when it was complete?"); // SPINNING ANIMATION
        // RANDOM SUB-SUB-QUESTION
        Console.WriteLine("Well done!!");
        // spin animation
        // end of activity
    }

}
