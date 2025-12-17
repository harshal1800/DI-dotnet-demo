namespace DI_Demo.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from Dependency Injection";
        }
    }
}
