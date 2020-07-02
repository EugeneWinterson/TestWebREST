using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebREST.Controllers;

namespace UnitTestREST
{
    [TestClass]
    public class UsersControllerTest
    {
        [TestMethod]
        public void GetQueryWillReturnJSON()
        {
            UsersController usersController = new UsersController();

            string expected = "{\"Id\":0,\"Name\":\"testName1\",\"SurName\":\"testSurName1\"}";
            string actual = usersController.Get(0);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetQueryWillReturnOverrideData()
        {
            UsersController usersController = new UsersController();

            User InputData = new User(1,"Georgy","Ivanovich");

            string expected = "{\"Id\":1,\"Name\":\"Georgy\",\"SurName\":\"Ivanovich\"}";

            string actual = usersController.Put(1, InputData);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateNewUserField() 
        {
            UsersController usersController = new UsersController();

            string expected = "[{\"Id\":0,\"Name\":\"testName1\",\"SurName\":\"testSurName1\"},{\"Id\":1,\"Name\":\"testName2\",\"SurName\":\"testSurName2\"},{\"Id\":2,\"Name\":\"testName3\",\"SurName\":\"testSurName3\"},{\"Id\":5,\"Name\":\"Anna\",\"SurName\":\"Detova\"}]";
            string actual = usersController.Post(new User(5, "Anna", "Detova"));

            Assert.AreEqual(expected, actual);
        }
    }
}
