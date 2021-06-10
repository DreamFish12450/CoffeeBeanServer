using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeBean.Bean;

namespace CoffeeBean.dao
{
    public interface IOnlineUser
    {
        Task<IEnumerable<OnlineUser>> GetOneOnline(string currentName);
        Task<bool> AddOnlineUserAsync(OnlineUser user);
        Task<bool> DeleteOnlineUserAsync(string name);
    }
}