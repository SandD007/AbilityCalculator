// See https://aka.ms/new-console-template for more information
using AbilityScoreCalculator;

AbilityCalculator calculator = new AbilityCalculator();
while (true)
{
    calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
    calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
    calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
    calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");

    calculator.CalculateAbilityScore();

    Console.WriteLine("Calculated ability score: " + calculator.Score);
    Console.WriteLine("Press Q to quit, any other key to continue");

    char keyChar = Console.ReadKey(true).KeyChar;
    
    if (keyChar == 'Q' || keyChar == 'q') return;
}

static int ReadInt(int lastUsedValue, string prompt)
{
    Console.WriteLine(prompt + " " + "[" + lastUsedValue + "]:");
    string answer = Console.ReadLine();
    if (int.TryParse(answer, out int resut))
    {
        Console.WriteLine("   using value " + resut);
        return resut;
    }
    else
    {
        Console.WriteLine("   using value " + lastUsedValue);
        return lastUsedValue;
    }
}

static double ReadDouble(double lastUsedValue, string prompt)
{
    Console.WriteLine(prompt + " " + "[" + lastUsedValue + "]:");
    string answer = Console.ReadLine();
    if (double.TryParse(answer, out double resut))
    {
        Console.WriteLine("   using value " + resut);
        return resut;
    }
    else
    {
        Console.WriteLine("   using value " + lastUsedValue);
        return lastUsedValue;
    }
}
