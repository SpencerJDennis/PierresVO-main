using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTests : IDisposable
  {

    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

    [TestMethod]
  public void GetName_ReturnsName_String()
  {
    //Arrange
    string name = "Test Category";
    Category newCategory = new Category(name);

    //Act
    string result = newCategory.Name;

    //Assert
    Assert.AreEqual(name, result);
  }

    [TestMethod]
  public void GetId_ReturnsCategoryId_Int()
  {
    //Arrange
    string name = "Test Category";
    Category newCategory = new Category(name);

    //Act
    int result = newCategory.Id;

    //Assert
    Assert.AreEqual(1, result);
  }

    [TestMethod]
  public void AddItem_AssociatesItemWithCategory_ItemList()
  {
    //Arrange
    string description = "Walk the dog.";
    Item newItem = new Item(description);
    List<Item> newList = new List<Item> { newItem };
    string name = "Work";
    Category newCategory = new Category(name);
    newCategory.AddItem(newItem);

    //Act
    List<Item> result = newCategory.Items;

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }


  }
}