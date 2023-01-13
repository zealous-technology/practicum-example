namespace HelloWorld.Console
{
    internal interface IMessageProvider
    {
        string GetMessage();
    }


    internal class MessageProvider : IMessageProvider
    {
        public string GetMessage() => "Hello world!";
    }
}
