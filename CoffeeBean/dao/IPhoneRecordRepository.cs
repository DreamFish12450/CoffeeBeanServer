using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeBean.Bean;

namespace CoffeeBean.dao
{
    public interface IPhoneRecordRepository
    {
        Task<IEnumerable<PhoneRecord>> GetRecordByReceiverId(int receiverId);
        Task<IEnumerable<PhoneRecord>> GetRecordByReceiverIdAndNoteName(int receiverId,string noteName);
    }
}