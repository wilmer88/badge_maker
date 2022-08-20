namespace CatWorx.BadgeMaker
{
    class Employee
    {
        
          public string? FirstName {get; set;}
           public string? LastName {get; set;}
           public static int? created { get; private set; } = 0;
            public Employee ()
            {
                Employee.created += 1;
            }
            public void PrintAttributes ()
    {
      Console.WriteLine("This student's first name is " + this.FirstName + ".");
      Console.WriteLine("This student's last name is " + this.LastName + ".");


    }
        
    } 
}
