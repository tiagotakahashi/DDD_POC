using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FCV.Domain.Aggregates.UserAggregates;

namespace FCV.Domain.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            //Arrange
            var user = new User { ID = 1 };
            var expected = "FCV.Domain.Aggregates.UserAggregates.User 1";

            //Act
            var stringValue = user.ToString();

            //Assert
            Assert.AreEqual(expected, stringValue);
        }

        [TestMethod]
        public void EqualsTest()
        {
            //Arrange
            var oneObject = new User { ID = 1, Nome = "Peter Doe" };
            var anotherObject = new User { ID = 1, Nome = "John Doe" };

            //Act
            var samePerson = anotherObject.Equals(oneObject);

            //Assert
            Assert.AreEqual(true, samePerson);
        }

        [TestMethod]
        public void NotEqualsTest()
        {
            //Arrange
            var oneObject = new User
            {
                ID = 1,
                Nome = "John Doe",
                Email = "asd@asd.com",
                Senha = "1234567",
                Tipo = TipoUsuario.Admin,
                LastAccess = DateTime.Now.Date
            };
            var anotherObject = new User
            {
                ID = 2,
                Nome = "John Doe",
                Email = "asd@asd.com",
                Senha = "1234567",
                Tipo = TipoUsuario.Admin,
                LastAccess = DateTime.Now.Date
            };

            //Act
            var diferentPerson = oneObject != anotherObject;

            //Assert
            Assert.AreEqual(true, diferentPerson);
        }

        [TestMethod]
        public void NullEqualsTest()
        {
            //Arrange
            var oneObject = new User { ID = 1, Nome = "Peter Doe" };
            User anotherObject = null;

            //Act
            var samePerson = oneObject.Equals(anotherObject);

            //Assert
            Assert.AreEqual(false, samePerson);
        }

        [TestMethod]
        public void HashCodeTest()
        {
            //Arrange
            var oneObject = new User { ID = 1 };

            //Act
            var hashCode = oneObject.GetHashCode();

            //Assert
            Assert.AreEqual(-1936074551, hashCode);
        }
    }
}
