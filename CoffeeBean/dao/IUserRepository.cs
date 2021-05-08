using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeBean.Bean;

namespace CoffeeBean.dao
{
    public interface IUserRepository
    {
        // why task
        // 根本上是解决异步问题 提高性能
        // net4.0在ThreadPool的基础上推出了Task，Task拥有线程池的优点:
        // ThreadPool相对于Thread来说可以减少线程的创建，有效减小系统开销同时也解决了使用线程池不易控制的弊端。
        Task<IEnumerable<userInfo>> GetUserList();
        Task<userInfo> GetByUsernameAsync(string username);

        Task<bool> AddUserAsync(userInfo user);
    }
}