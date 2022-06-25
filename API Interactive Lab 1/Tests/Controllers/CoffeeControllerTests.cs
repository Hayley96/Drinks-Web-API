using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffeeNoName()
        {
            Coffee expectedResultCoffee = new Coffee { Name = "latte", Id = -1};

            var controller = new CoffeeController();
            var result = controller.Get(null);
            Assert.AreEqual(expectedResultCoffee.Name, result.Name);
            Assert.AreEqual(expectedResultCoffee.Id, result.Id);
        }

        [Test]
        public void TestGetCoffeeByName()
        {
            string name = "frappe";
            Coffee expectedResultCoffee = new Coffee { Name = name, Id = 3};

            var controller = new CoffeeController();
            var result = controller.Get(name);
            Assert.AreEqual(expectedResultCoffee.Name, result.Name);
            Assert.AreEqual(expectedResultCoffee.Id, result.Id);
        }

        [Test]
        public void Test_Get_CoffeeLover()
        {
            string expectedContent = "I love, love, love coffeeeeee!";
            var controller = new CoffeeController();
            var result = controller.GetCoffeeLover();
            Assert.AreEqual(expectedContent, result);
        }
    }
}
