using System.Threading.Tasks;

namespace PTApi.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}