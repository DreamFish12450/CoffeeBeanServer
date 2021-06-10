using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeBean.Bean;

namespace CoffeeBean.dao
{
    public interface IUserPostRepository
    {
        Task<IEnumerable<UserPost>> GetUserPostByUserId(int userid);
    }
}