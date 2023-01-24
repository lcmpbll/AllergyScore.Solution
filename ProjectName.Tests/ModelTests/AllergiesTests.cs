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
//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item();
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       string result = newItem.Description;
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
// public void GetDescription_ReturnsDescription_String()
// {
//   //Arrange
//   string description = "Walk the dog.";
//   Item newItem = new Item(description);

//   //Act
//   string result = newItem.Description;

//   //Assert
//   Assert.AreEqual(description, result);
// }

  }
}