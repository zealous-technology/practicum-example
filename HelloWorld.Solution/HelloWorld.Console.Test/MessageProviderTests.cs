
namespace HelloWorld.Console.Test
{
    [TestClass]
    public class MessageProviderTests
    {
        private readonly IMessageProvider _sut;

        public MessageProviderTests()
        {
            _sut = new MessageProvider();
        }

        [TestMethod]
        public void TestMessageIsNotNull()
        {
            Assert.IsNotNull(_sut.GetMessage());
        }

        [TestMethod]
        public void TestMessageIsHelloWorld()
        {
            Assert.AreEqual("Hello world!", _sut.GetMessage());
        }

        [TestMethod]
        public void TestMessageIsPersonalized()
        {
            Assert.AreEqual("Hello Steve!", _sut.GetMessage("Steve"));
        }
    }
}