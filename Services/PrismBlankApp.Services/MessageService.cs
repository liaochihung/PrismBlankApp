using PrismBlankApp.Services.Interfaces;

namespace PrismBlankApp.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
