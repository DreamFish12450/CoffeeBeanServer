using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CoffeeBean.Bean;
using CoffeeBean.util;
using Dapper;
using NUnit.Framework;

namespace CoffeeBean.dao
{
    public class OnlineUserRepository : IOnlineUser
    {
        public Task<IEnumerable<OnlineUser>> GetOneOnline(string currentName)
        {
            using (IDbConnection conn = DbConfig.GetSqlConnection())
            {
                string sql = "SELECT * from onlineUser";
                var list = conn.QueryAsync<OnlineUser>(sql);
                var userList = list.Result.Where(u => u.Name != currentName).ToList();
                Console.WriteLine(userList.ToString());
                Random rd = new Random();
                int index = rd.Next(userList.Count);
                var model = userList[index];
                var onlineUsers = new List<OnlineUser> {model}.AsEnumerable();


                return Task.FromResult<IEnumerable<OnlineUser>>(onlineUsers);
            }
        }

        public async Task<bool> AddOnlineUserAsync(OnlineUser user)
        {
            using (IDbConnection conn = DbConfig.GetSqlConnection())
            {
                var sql = @"insert into onlineUser(phoneNumber,name) values (@phoneNumber,@name)";

                return await conn.ExecuteAsync(sql, user) > 0;

            }
        }

        public async Task<bool> DeleteOnlineUserAsync(string name)
        {
            using (IDbConnection conn = DbConfig.GetSqlConnection())
            {
                
                var sql = @"delete from onlineUser where name = @name ";
                return await conn.ExecuteAsync(sql, new{name = name}) > 0;
            }
        }
    }
}