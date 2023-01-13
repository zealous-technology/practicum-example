namespace HelloWorld.Console
{
    public interface IMessageProvider
    {
        string GetMessage();

        string GetMessage(string who);
    }


    public class MessageProvider : IMessageProvider
    {
        public string GetMessage() => "Hello world!";

        public string GetMessage(string who) => $"Hello {who}!";
    }
}
