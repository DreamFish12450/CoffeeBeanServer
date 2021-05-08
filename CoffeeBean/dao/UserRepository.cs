using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CoffeeBean.Bean;
using CoffeeBean.util;
using Dapper;

namespace CoffeeBean.dao
{
    public class UserRepository: IUserRepository
    {
        // async/await 异步同步编程
        // async修饰的方法为异步方法。await之前的代码为同步执行，await修饰的代码为异步执行这里也就是新建了一个子线程
        // 参考链接 https://www.cnblogs.com/feipeng8848/p/10188871.html；https://www.jianshu.com/p/0e2a479d5c53
        public async Task<IEnumerable<userInfo>> GetUserList()
        {
            using (IDbConnection conn = DbConfig.GetSqlConnection())
            {
                //使用Dapper自带的Async方法
                //参考链接https://dapper-tutorial.net/async
                return await conn.QueryAsync<userInfo>(@"SELECT *
                                        FROM userInfo");
            }
        }

        public async Task<userInfo> GetByUsernameAsync(string username)
        {
            using (IDbConnection conn = DbConfig.GetSqlConnection())
            {
                string sql = @"SELECT * From userInfo where username = @username";
                return await conn.QueryFirstOrDefaultAsync<userInfo>(sql, new {username = username});
            }
        }

        public async Task<bool> AddUserAsync(userInfo user)
        {
            using (IDbConnection conn = DbConfig.GetSqlConnection())
            {
                var sql =
                    @"insert into userInfo(id,username,password,vip_level,amount) values (@id,@username,@password,@vipLevel,@amount)";
                return await conn.ExecuteAsync(sql, user) > 0;
            }
            
        }
    }
}