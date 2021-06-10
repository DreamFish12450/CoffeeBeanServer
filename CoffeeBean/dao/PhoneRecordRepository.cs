using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeBean.Bean;
using Dapper;
using Microsoft.Data.Sqlite;

namespace CoffeeBean.dao
{
    public class PhoneRecordRepository: IPhoneRecordRepository
    {
        public async Task<IEnumerable<PhoneRecord>> GetRecordByReceiverId(int receiverId)
        {
            using (var conn = new SqliteConnection("Data Source=identifier.sqlite"))
            {
                var sql =
                    @"select * from main.phoneRecord where receiverId = @receiverId";
                return await conn.QueryAsync<PhoneRecord>(sql, new {receiverId = receiverId});
            }
        }

        public async Task<IEnumerable<PhoneRecord>> GetRecordByReceiverIdAndNoteName(int receiverId, string noteName)
        {
            using (var conn = new SqliteConnection("Data Source=identifier.sqlite"))
            {
                var sql =
                    @"select * from main.phoneRecord where receiverId = @receiverId and noteName = @noteName";
                return await conn.QueryAsync<PhoneRecord>(sql, new {receiverId = receiverId,noteName = noteName});
            } 
        }
    }
}