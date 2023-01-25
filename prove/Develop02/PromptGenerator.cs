using System;
// the prompt is the random questions to ask the user when they select to write a journal
class PromptGenerator
{
    // list of attributes/variables what they have
    public List<string> _questions = new List<string>();

    public PromptGenerator()
    {
        // Questions for _quesions list
        _questions.Add("Write about what happened today that was fun");
        _questions.Add("what was something that your wife did that was great!");
        _questions.Add("write about your dad");
        _questions.Add("write about your evening.");
        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What was the best part of my day?");
        _questions.Add("How did I see the hand of the Lord in my life today?");
        _questions.Add("What was the strongest emotion I felt today?");
        _questions.Add("If I had one thing I could do over today, what would it be?");
    }

    // Methods what they do
    // returns a random question from questions list and adds it to Entry
    public string getQuestion()
    {
        Random rnd = new Random(); //initializing the random method in C#
        return _questions[rnd.Next(0, _questions.Count)];
    }
}