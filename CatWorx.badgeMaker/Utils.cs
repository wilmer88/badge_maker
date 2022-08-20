namespace CatWorx.BadgeMaker
{
  class Util
  {
       public static void SaveAttribute(string attribute, Dictionary<string, string?> Employee)
    {
      Console.Write("Please enter the student's " + attribute + ". ");
      string? _attribute = Console.ReadLine();
      Employee.Add(attribute, _attribute);
    }
        public static void PrintEntries(Dictionary<string, string> Employee)
    {
      foreach (KeyValuePair<string, string> pair in Employee)
      {
        Console.WriteLine("The student's " + pair.Key + " is " + pair.Value + ".");
      }
    }
    public static bool Confirm()
    {
      Console.Write("Is this information correct? (Y/n) ");
      string? confirmation = Console.ReadLine();

      if (confirmation == "y" || confirmation == "Y")
        return true;
      else
        return false;
    }
        public static string? PromptForAttribute(string attribute)
    {
      Console.WriteLine("Please enter the student's " + attribute + ".");
      return  Console.ReadLine();
    }

  }
}