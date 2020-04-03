using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOne_CheckCount()
        {
            //Arrange 
            CustomList<int> customList = new CustomList<int>();
            int expected = 1;
            int actual;
            //Act
            customList.Add(22);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddOne_CheckIndex0()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            string expected = "Moon";
            string actual;
            //Act
            customList.Add("Moon");
            actual = customList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddOne_CheckCapacity()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            int expected = 4;
            int actual;
            //Act
            customList.Add("Moon");
            actual = customList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // Add 5 items to list check count is equal to 5

        // Add 5 items to list check index 4 is equal to the 5th item you added

        // Add 5 items to list check capacity is equal to 8
        [TestMethod]
        public void AddFive_CheckCount()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            int expected = 5;
            int actual;
            //Act
            customList.Add("Sun");
            customList.Add("Stars");
            customList.Add("Mars");
            customList.Add("Earth");
            customList.Add("Venus");
           
            actual = customList.Count;
           
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFive_CheckIndex4()
        {
            //Arrange 
            CustomList<string> words =  new CustomList<string>();
            string expected = "Venus";
            string actual;
            
            //Act
            words.Add("Sun");
            words.Add("Stars");
            words.Add("Mars");
            words.Add("Earth");
            words.Add("Venus");
           
            actual = words[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFive_CheckCapacity()
        {
            //Arrange 
            CustomList<string> words = new CustomList<string>();
            int expected = 8;
            int actual;
            //Act
            words.Add("Sun");
            words.Add("Stars");
            words.Add("Mars");
            words.Add("Earth");
            words.Add("Venus");
                    
            actual = words.Capacity;
           
            //Assert
            Assert.AreEqual(expected, actual);
        }
            
        [TestMethod] // Building my Test to remove an object check the index and capacity. 
        public void RemoveFive_CheckCount()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            int expected = 0;
            int actual;
            ////////Act
            customList.Add("Sun");
            customList.Add("Stars");
            customList.Add("Mars");
            customList.Add("Earth");
            customList.Add("Venus");
            
            customList.Remove("Sun");
            customList.Remove("Stars");
            customList.Remove("Mars");
            customList.Remove("Earth");
            customList.Remove("Venus");           
            
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveFour_CheckCount()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            int expected = 0;
            int actual;

            ////////Act
            customList.Add("Sun");
            customList.Add("Stars");
            customList.Add("Mars");
            customList.Add("Earth");
            customList.Add("Venus");

            customList.Remove("Sun");
            customList.Remove("Stars");
            customList.Remove("Mars");
            customList.Remove("Earth");
            customList.Remove("Jupiter");

            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveThree_CheckCount()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            int expected = 2;
            int actual;
            ////////Act
            customList.Add("Sun");
            customList.Add("Stars");
            customList.Add("Mars");
            customList.Add("Earth");
            customList.Add("Venus");

            customList.Remove("Sun");
            customList.Remove("Stars");
            customList.Remove("Mars");
           
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveTwo_CheckCount()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            int expected = 3;
            int actual;
            ////////Act
            customList.Add("Sun");
            customList.Add("Stars");
            customList.Add("Mars");
            customList.Add("Earth");
            customList.Add("Venus");

            customList.Remove("Sun");
            customList.Remove("Stars");
           
            actual = customList.Count;
            
            //Assert
             Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveOne_CheckCount()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            int expected = 4;
            int actual;
            ////////Act
            customList.Add("Sun");
            customList.Add("Stars");
            customList.Add("Mars");
            customList.Add("Earth");
            customList.Add("Venus");

            customList.Remove("Sun");
           
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveOne_CheckIndex4()
        {
            //Arrange 
            CustomList<string> words = new CustomList<string>();
            string expected = "Venus";
            string actual;

            //Act
            words.Add("Sun");
            words.Add("Stars");
            words.Add("Mars");
            words.Add("Earth");
            words.Add("Venus");
            
            words.Remove("Sun");
                   
            actual = words[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveTwo_CheckCapacity()
        {
            //Arrange 
            CustomList<string> words = new CustomList<string>();
            int expected = 8;
            int actual;
            //Act
            words.Add("Sun");
            words.Add("Stars");
            words.Add("Mars");
            words.Add("Earth");
            words.Add("Venus");

            words.Remove("Sun");
            words.Remove("Stars");
                       
            actual = words.Capacity;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveDuplicate_CheckOtherStillThere()
        {
            //Arrange 
            CustomList<int> words = new CustomList<int>();
            int expected = 44;
            int actual;
            //Act
            words.Add(2);
            words.Add(44);
            words.Add(21);
            words.Add(44);
            words.Add(6);

            words.Remove(21);

            actual = words[3];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddOneNumberToString()
        {
            //Arrange 
            CustomList<int> Number = new CustomList<int>();
            int expected = 1;
            int actual;
            //Act
            Number.Add(1);
            actual = Number.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumberToString()
        {
            //Arrange 
            CustomList<int> Number = new CustomList<int>();
            int expected = 2;
            int actual;
            //Act
            Number.Add(2);
            actual = Number.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddOneToString_CheckIndex0()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            string expected = "Moon";
            string actual;
            //Act
            customList.Add("Moon");
            actual = customList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFiveToString_CheckCount()
        {
            //Arrange 
            CustomList<string> customList = new CustomList<string>();
            int expected = 5;
            int actual;
            //Act
            customList.Add("Sun");
            customList.Add("Stars");
            customList.Add("Mars");
            customList.Add("Earth");
            customList.Add("Venus");

            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
         [TestMethod]
        public void AddFiveToString_CheckCapacity()
        {
            //Arrange 
            CustomList<string> words = new CustomList<string>();
            int expected = 8;
            int actual;
            //Act
            words.Add("Sun");
            words.Add("Stars");
            words.Add("Mars");
            words.Add("Earth");
            words.Add("Venus");

            actual = words.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
