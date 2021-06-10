using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CoffeeBean.Bean;
using CoffeeBean.util;
using Dapper;
using Microsoft.Data.Sqlite;

namespace CoffeeBean.dao
{
    public class UserPostRepository : IUserPostRepository
    {
        public async Task<IEnumerable<UserPost>> GetUserPostByUserId(int userId)
        {
            using (var conn = new SqliteConnection("Data Source=identifier.sqlite"))
            {
                return  await conn.QueryAsync<UserPost>(@"SELECT *
                                        FROM userPost where userId = @userId", new {userId = userId});
                
            }
        }
    }
}