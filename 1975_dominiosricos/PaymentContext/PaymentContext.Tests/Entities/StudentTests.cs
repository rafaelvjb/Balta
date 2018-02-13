using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod()
        {
            var subscription = new Subscription(null);
            //var student = new Student(firstName:"first",lastName:"last",document:"123456789",email:"hello@balta.io");
        }

        public void AdicionarAssinatura()
        {
            var name = new Name("primeiro", "ultimo");
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription(){
            var name = new Name("Bruce", "Wayne");
            var document = new Document("35111507795",EDocumentType.CPF);
            Assert.Fail();
        }
    }
}