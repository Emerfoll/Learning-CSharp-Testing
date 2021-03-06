using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //--Act
            

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
