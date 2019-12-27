using Domain.Model;
using NUnit.Framework;

namespace Tests
{
    public class EditModeTests
    {
        [Test]
        public void UserTest()
        {
            var user = new User(0, "Alice", false);
            
            Assert.AreEqual(0, user.Id);
            Assert.AreEqual("Alice", user.Name.Value);
            Assert.AreEqual(false, user.IsPaid.Value);
        }
    }
}
