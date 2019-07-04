using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stockmgmtsystem;

namespace TestStockMgmtsystem.UnitTests
{
    [TestClass]
    public class StockMgmtSystemTest
    {
        [TestMethod]
        public void InitialRegister_ValidPin_ReturnsString()
        {
            //Arrange
            var initialregister = new User();

            //Act
            initialregister.Pin = "asd";
            var result = initialregister.Register();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Login_ValidPin_ReturnTrue()
        {
            //Arrange
            var login = new User();

            //Act
            login.Pin = "asd";
            var result = login.Login();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ForgotPin_ValidRecoveryCode_ReturnTrue()
        {
            //Arrange
            var forgotpin = new User();

            //Act
            forgotpin.RecoveryCode = "xqxc9239XQ";
            var result = forgotpin.ForgotPin();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ChangePin_ValidPin_ReturnTrue()
        {
            //Arrange
            var changepin = new User();

            //Act
            changepin.OldPin = "123123";
            changepin.RecoveryCode = "xqxc9239XQ";
            changepin.Pin = "asd123";
            var result = changepin.ChangePin();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddCategory_ValidCategory_ReturnTrue()
        {
            //Arrange
            var addcategory = new LiquorCategory();

            //Act
            addcategory.CategoryName = "category3";
            var result = addcategory.AddCategory();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddLiquor_ValidLiquor_ReturnTrue()
        {
            //Arrange
            var addliquor = new Liquor();

            //Act
            addliquor.LiquorName = "liquor2";
            addliquor.LiquorPrice = 500;
            addliquor.CategoryId = 2;
            addliquor.LiquorQuantity = 21;
            addliquor.ThresholdQuantity = 20;
            var result = addliquor.AddLiquor();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddLoyalCustomer_ValidEmail_ReturnTrue()
        {
            //Arrange
            var addloyalcustomer = new LoyalCustomer();

            //Act
            addloyalcustomer.Email = "user3@mail.com";
            var result = addloyalcustomer.AddLoyalCustomer();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RestockLiquor_ValidLiquor_ReturnsTrue()
        {
            //Arrange
            var restockliquor = new Liquor();

            //Act
            restockliquor.LiquorName = "saas";
            restockliquor.LiquorId = 4;
            restockliquor.LiquorQuantity = 5;
            var result = restockliquor.RestockLiquor();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void UpdateLiquor_ValidLiquor_ReturnTrue()
        {
            //Arrange
            var updateliquor = new Liquor();

            //Act
            updateliquor.LiquorName = "liquor2";
            updateliquor.LiquorId = 7;
            updateliquor.LiquorPrice = 550;
            updateliquor.CategoryId = 2;
            updateliquor.LiquorQuantity = 20;
            updateliquor.ThresholdQuantity = 15;
            bool flag = true;
            var result = updateliquor.UpdateLiquor(flag);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteLiquor_ValidLiquor_ReturnTrue()
        {
            //Arrange
            var deleteliquor = new Liquor();

            //Act
            deleteliquor.LiquorName = "asdasd";
            deleteliquor.LiquorId = 2;
            var result = deleteliquor.DeleteLiquor();

            //Assert
            Assert.IsTrue(result);
        }
    }
}
