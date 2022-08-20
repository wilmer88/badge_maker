// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main (String[] args)
    {
       while (true) {

        Employee student = new Employee();

        // Or, if fields are private, something like:
        //   student.setFirstName(promptForAttribute("first name"));

        student.FirstName = Util.PromptForAttribute("first name");
        student.LastName = Util.PromptForAttribute("last name");


        student.PrintAttributes();

        if (Util.Confirm())
          break;
      }
    
    }
 

 }
 
}
// // See https://aka.ms/new-console-template for more information
// using System;
// using System.Collections.Generic;

// namespace CatWorx.BadgeMaker
// {
//   class Program
//   {
//     static void Main (String[] args)
//     {
      
//     static List<string> AddEmployee()
//     {
//       List<string> employees = new List<string>();
//       while (true)
//       {
//               Console.WriteLine("Please enter first name: ");
//                     Console.WriteLine("Please enter a last name: ");
//       string? inputFirst = Console.ReadLine();
//       string? inputLast = Console.ReadLine();
//          if(inputFirst == ""|| inputFirst is null){
//       break;
//            }
//             if (inputLast == ""|| inputLast is null){
//             break;
//            }
//             Console.Write("Is this information correct? (Y/n) ");
//               string? confirmation = Console.ReadLine();
//       if (confirmation == "y" || confirmation == "Y"){
//             employees.Add(inputFirst);
//              employees.Add(inputLast);
//           break;
//       }
      
          
            
//       }
                  
//   return employees;

//     }
//        AddEmployee();
    
//     }
 

//  }
 
// }




// See https://aka.ms/new-console-template for more information
// using System;
// using System.Collections.Generic;

// namespace CatWorx.BadgeMaker
// {
//   class Program
//   {
//           static List<string> GetEmployees() 
//           {
//           List<string> employees = new List<string>();
//           while (true)
//         {
//               Console.WriteLine("Please enter a name: ");
//       string? input = Console.ReadLine();
      
//       // public getemployeeName(string text)=>
//       // (input) = (text);

//        if(input == ""|| input is null){
//       break;
//            }
//         employees.Add(input);
//         }
//     return employees;
//           }
//             static void PrintEmployees(List<string> employees)
 
//  {
//     for (int i = 0; i < employees.Count; i++)
//     {
//       Console.WriteLine(employees[i]);
//     }
//   }
//          static void Main(string[] args)
//     {
//     List<string> employees = GetEmployees();
//     PrintEmployees(employees);
//    }
//  }
// }



   
      

 
