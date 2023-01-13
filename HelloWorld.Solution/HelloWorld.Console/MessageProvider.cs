namespace HelloWorld.Console
{
    public interface IMessageProvider
    {
        string GetMessage();
    }


    public class MessageProvider : IMessageProvider
    {
        public string GetMessage() => "Hello world!";
    }
}
