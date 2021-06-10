using System.Threading.Tasks;
using TRMDesktopUI.Models;

namespace TRMDesktopUI.Library.Api
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}