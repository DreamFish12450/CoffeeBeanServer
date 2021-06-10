using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeBean.Bean;
using Dapper;
using Microsoft.Data.Sqlite;

namespace CoffeeBean.dao
{
    public class ContactInfoRepository:IContactInfoRepository
    {
        public async Task<IEnumerable<ContactInfo>> GetContactInfoByNoteName(string noteName)
        {
            using (var conn = new SqliteConnection("Data Source=identifier.sqlite"))
            {
                var sql =
                    @"select * from main.contactInfo where noteName = @noteName ";
                return await conn.QueryAsync<ContactInfo>(sql, new {noteName = noteName});
            } 
        }
    }
}