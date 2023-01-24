using System;
using System.Collections.Generic;
using System.Linq;
using Allergies.Models;

namespace AllergyChecker
{
  public class Program
  {
    public static void Main()
    {
      Allergens newAllergies = new Allergens();
      Console.WriteLine(value: "What is your Allergy Score?");
      string input = Console.ReadLine();
      int Score = int.Parse(s: input);
      
      List<string> allergies = new List<string>();
      List<string> allAllergies = newAllergies.AllergicTo(Score: Score, allergiesList: allergies);
      
      if(allAllergies.Count == 0){
        Console.WriteLine(value: "The results of this test indicate you do not have allergies.");
      } else {
          Console.WriteLine(value: "The results of this test indicate you have " + allAllergies.Count + " allergies. You are allergic to:");
        for(int i = 0; i < allAllergies.Count; i ++){
          Console.WriteLine(value: allAllergies[index: i]);
        }
      }
      
      Console.WriteLine(value: "Would you like to check another Allergy Score? Y or N");
      string response = Console.ReadLine();
      if(response.ToLower() == "y"){
        Main();
      } else {
        Environment.Exit(exitCode: 0);
      }
      
      
    }
  }
}