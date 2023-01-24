using System.Collections.Generic;
using System;

namespace Allergies.Models
{
  public class Allergens
  {
    public int Score { get; set; }
   
   public List<string> AllergicTo(int Score) {
    List<string> allergiesList = new List<string>();
    if(Score % 2 != 0){
      allergiesList.Add(item: "eggs");
    }
    return allergiesList;
   }
  }
}