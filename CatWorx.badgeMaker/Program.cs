﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
          static List<string> GetEmployees() 
          {
          List<string> employees = new List<string>();
          while (true)
        {
              Console.WriteLine("Please enter a name: ");
      string input = Console.ReadLine();
      employees.Add(input);
       if(input == ""){
      break;
           }
        employees.Add(input);
        }
    return employees;
          }
            static void PrintEmployees(List<string> employees)
 
 {
    for (int i = 0; i < employees.Count; i++)
    {
      Console.WriteLine(employees[i]);
    }
  }
         static void Main(string[] args)
    {
    List<string> employees = GetEmployees();
    PrintEmployees(employees);
   }
 }
}



   
      

 
