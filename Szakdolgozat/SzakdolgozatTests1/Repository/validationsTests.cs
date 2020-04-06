using Microsoft.VisualStudio.TestTools.UnitTesting;
using Szakdolgozat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat.Repository.Tests
{
    [TestClass()]
    public class ValidationsTests
    {
        [TestMethod()]
        public void IsValidValueTestTrue()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidValue("20000") == true)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("Az érték helyes mégis false-al tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }
        [TestMethod()]
        public void IsValidValueTestFalse()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidValue("020000") == false)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("Az érték hibás mégis true-val tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }

        [TestMethod()]
        public void IsValidEmailTestTrue()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidEmail("lengyelnorbi5@gmail.com") == true)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("Az email cím helyes mégis false-al tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }
        [TestMethod()]
        public void IsValidEmailTestFalse()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidValue("lengyelnorbi5") == false)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("Az email cím hibás mégis true-val tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }

        [TestMethod()]
        public void IsValidNameTestTrue()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidName("Lengyel Norbi") == true)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("A név helyes mégis false-al tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }
        [TestMethod()]
        public void IsValidNameTestFalse()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidName("Lengyel") == false)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("A név hibás mégis true-val tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }

        [TestMethod()]
        public void IsValidPhoneNumberTestTrue()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidPhoneNumber("+36201234567") == true)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("A dátum helyes mégis false-al tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }
        [TestMethod()]
        public void IsValidPhoneNumberTestFalse()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidPhoneNumber("+201234567") == false)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("A telefonszám hibás mégis true-val tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }

        [TestMethod()]
        public void IsValidDateTestTrue()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidDate("2020.03.03") == true)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("A dátum helyes mégis false-al tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }
        [TestMethod()]
        public void IsValidDateTestFalse()
        {
            try
            {
                Validations val = new Validations();
                if (val.IsValidDate("20.20.03.03.") == false)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail("A dátum hibás mégis true-val tér vissza!");
                }
            }
            catch (Exception)
            {
                Assert.Fail("Nincs bemenet, mégsem ad hibát.");
            }
        }
    }
}