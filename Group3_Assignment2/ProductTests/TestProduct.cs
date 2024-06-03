using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group3_Assignment2;
using NUnit.Framework;

namespace ProductTests
{
    [TestFixture]

    public class TestProduct
    {
        [Test]
        public void ValidProductID_Input6andIphoneand650and7_OutputProductID()
        {
            //Arrange
            int productID = 6;
            string productName = "Iphone";
            int price = 650;
            int stock = 7;

            int expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductID_Input60000andSamsungand650and7_OutputProductID()
        {
            //Arrange
            int productID = 60000;
            string productName = "Samsung";
            int price = 650;
            int stock = 7;

            int expected = 60000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductID_Input45000andIphoneand650and7_OutputProductID()
        {
            //Arrange
            int productID = 45000;
            string productName = "Iphone";
            int price = 650;
            int stock = 7;

            int expected = 45000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductName_Input6andIphoneand650and7_OutputProductName()
        {
            //Arrange
            int productID = 6;
            string productName = "Iphone";
            int price = 650;
            int stock = 7;

            string expected = "Iphone";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductName_Input6andSamsungand650and7_OutputProductName()
        {
            //Arrange
            int productID = 6;
            string productName = "Samsung";
            int price = 650;
            int stock = 7;

            string expected = "Samsung";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductName_Input6andAsusand650and7_OutputProductName()
        {
            //Arrange
            int productID = 6;
            string productName = "Asus";
            int price = 650;
            int stock = 7;

            string expected = "Asus";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductStock_Input6andSamsungand250and6_OutputProductStock()
        {
            //Arrange
            int productID = 6;
            string productName = "Samsung";
            int price = 250;
            int stock = 6;

            int expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductStock_Input6andMacbookand250and600000_OutputProductStock()
        {
            //Arrange
            int productID = 6;
            string productName = "Macbook";
            int price = 250;
            int stock = 600000;

            int expected = 600000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductStock_Input6andAsusand250and450000_OutputProductStock()
        {
            //Arrange
            int productID = 6;
            string productName = "Asus";
            int price = 250;
            int stock = 450000;

            int expected = 450000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductPrice_Input6andSamsungand6and6_OutputProductPrice()
        {
            //Arrange
            int productID = 6;
            string productName = "Samsung";
            int price = 6;
            int stock = 6;

            double expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductPrice_Input6andDelland6000and6_OutputProductPrice()
        {
            //Arrange
            int productID = 6;
            string productName = "Dell";
            int price = 6000;
            int stock = 6;

            double expected = 6000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidProductPrice_Input6andDelland4500and6_OutputProductPrice()
        {
            //Arrange
            int productID = 6;
            string productName = "Dell";
            int price = 4500;
            int stock = 6;

            double expected = 4500;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidIncreaseStock_Input750anDelland2700and100and6_OutputIncreasedstock()
        {
            //Arrange
            int productID = 750;
            string productName = "Dell";
            int price = 2700;
            int stock = 100;
            int increaseStock = 6;

            int expected = 106;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidIncreaseStock_Input750anDelland2700and100and600000_OutputIncreasedstock()
        {
            //Arrange
            int productID = 750;
            string productName = "Dell";
            int price = 2700;
            int stock = 100;
            int increaseStock = 600000;

            int expected = 600100;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidIncreaseStock_Input750anDelland2700and100and255500_OutputIncreasedstock()
        {
            //Arrange
            int productID = 750;
            string productName = "Dell";
            int price = 2700;
            int stock = 100;
            int increaseStock = 255500;

            int expected = 255600;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidDecreaseStock_Input750anDelland2700and100and10_OutputDecreaseStock()
        {
            //Arrange
            int productID = 750;
            string productName = "Dell";
            int price = 2700;
            int stock = 100;
            int DecreaseStock = 10;

            int expected = 90;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidDecreaseStock_Input750anDelland2700and100and250_OutputDecreaseStock()
        {
            //Arrange
            int productID = 750;
            string productName = "Dell";
            int price = 2700;
            int stock = 6000;
            int DecreaseStock = 250;

            int expected = 5750;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ValidDecreaseStock_Input750anDelland2700and100and1000_OutputDecreaseStock()
        {
            //Arrange
            int productID = 750;
            string productName = "Dell";
            int price = 2700;
            int stock = 6000;
            int DecreaseStock = 1000;

            int expected = 5000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}

