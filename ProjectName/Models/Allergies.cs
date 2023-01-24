using System.Collections.Generic;

namespace Allergies.Models
{
  public class Allergens
  {
    public int Score { get; set; }
    public List<string> allergiesList = new List<string>();
   
   
   
   
   public List<string> AllergicTo(int Score, List<string> allergiesList) {
    if(Score >= 128){
      Score -= 128;
      allergiesList.Add(item: "cats");
      AllergicTo( Score: Score, allergiesList: allergiesList );
    } else if(Score >= 64){
      Score -= 64;
      allergiesList.Add(item: "pollen");
      AllergicTo(Score: Score, allergiesList: allergiesList);
    } else if(Score >= 32){
      Score -= 32;
      allergiesList.Add(item: "chocolate");
      AllergicTo(Score: Score, allergiesList: allergiesList);
    } else if(Score >= 16){
      Score -= 16;
      allergiesList.Add(item: "tomatoes");
      AllergicTo(Score: Score, allergiesList: allergiesList);
    } else {
      return allergiesList;
    }
    return allergiesList;
   }
  }
}