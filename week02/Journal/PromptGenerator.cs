// The Prompt generator class

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetPrompt()
    {
        Random rnd = new Random();
        int choice = rnd.Next(_prompts.Count);

        return _prompts[choice];
    }
}