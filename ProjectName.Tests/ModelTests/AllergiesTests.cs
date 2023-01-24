using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    [TestMethod]
  public void CheckForCats_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "cats");
    List<string> result = allergies.AllergicTo(Score: 128,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
      [TestMethod]
  public void CheckForPollen_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "pollen");
    List<string> result = allergies.AllergicTo(Score: 64,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
    [TestMethod]
   public void CheckForCatsAndPollen_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "cats");
    newList.Add(item: "pollen");
    List<string> result = allergies.AllergicTo(Score: 192,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
    [TestMethod]
   public void CheckForChocolate_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "chocolate");
    
    List<string> result = allergies.AllergicTo(Score: 32,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
     [TestMethod]
   public void CheckForTomatoes_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "tomatoes");
    
    List<string> result = allergies.AllergicTo(Score: 16,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
  [TestMethod]
    public void CheckForStrawberries_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "strawberries");
    
    List<string> result = allergies.AllergicTo(Score: 8,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
   [TestMethod]
    public void CheckForShellfish_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "shellfish");
    
    List<string> result = allergies.AllergicTo(Score: 4,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
     [TestMethod]
    public void CheckForPeanuts_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "peanuts");
    
    List<string> result = allergies.AllergicTo(Score: 2,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
      [TestMethod]
    public void CheckForEggs_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    newList.Add(item: "eggs");
    
    List<string> result = allergies.AllergicTo(Score: 1,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }
  
      [TestMethod]
    public void CheckForNoAllergies_List()
  {
    //Arrange
    Allergens allergies = new Allergens();
    List<string> allergiesList = new List<string>();
    List<string> newList = new List<string>();
    
    
    List<string> result = allergies.AllergicTo(Score: 0,  allergiesList: allergiesList);
    
    CollectionAssert.AreEqual(expected: newList, actual: result);
  }



  }
}