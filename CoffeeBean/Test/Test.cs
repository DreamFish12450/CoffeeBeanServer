using System.Collections.Generic;
using CoffeeBean.Bean;
using Dapper;
using Microsoft.Data.Sqlite;
using NUnit.Framework;
namespace CoffeeBean.Test
{

    public class Test
    {
        [Test]
        public void testUserInfo()
        {
            using (var conn = new SqliteConnection("Data Source=identifier.sqlite"))
            {
                //使用Dapper自带的Async方法
                //参考链接https://dapper-tutorial.net/async
                var userInfos =  conn.QueryAsync<userInfo>(@"SELECT *
                                        FROM userInfo");
            }
        }
    }
}