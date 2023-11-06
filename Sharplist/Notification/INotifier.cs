using System.Threading.Tasks;

namespace Sharplist
{
    public interface INotifier
    {
        void Send(string email, string subject, string body);
    }
}
