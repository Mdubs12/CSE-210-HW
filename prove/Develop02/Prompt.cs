using System;

public class Prompt
{
    List<string> _questions = new List<string>()
    {
        "What was the best part of your day?",
        "What made you feel happy today?",
        "Did you try something different today?",
        "What is something you would change about today?",
        "Who made your day better? How?",
        "Did you do something for someone today?",
        "What was your favorite meal today?."
    };

    public string ReturnPrompt (int number)
    {
        return _questions[number];
    }



}