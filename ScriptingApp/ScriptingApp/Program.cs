using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

var automation = new Automation(
    text =>
    {
        Console.WriteLine(text);
    });

//AppDomain.CurrentDomain.GetAssemblies()
var options = ScriptOptions.Default
    .AddReferences(typeof(Automation).Assembly)
    .WithImports("System");

int result = 
    await CSharpScript
    .EvaluateAsync<int>(
        """
        Message("Привет")
        Message("Привет")
        """,
        options,
        automation,
        typeof(Automation));

Console.WriteLine(result);
Console.WriteLine(automation.MessageCount);

var data = await CSharpScript.RunAsync("""
        int x = 10 + 5;
        """,
        options,
        automation,
        typeof(Automation));

data = await data.ContinueWithAsync("x*2");

Console.WriteLine(data.ReturnValue);

public class Automation
{
    private readonly Action<string> _showMessage;
    public int MessageCount { get; set; } = 0;

    public Automation(Action<string> showMessage)
    {
        _showMessage = showMessage;
    }

    public void Message(string text)
    {
        _showMessage(text);
        MessageCount++;
    }
}