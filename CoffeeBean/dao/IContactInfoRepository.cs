using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeBean.Bean;

namespace CoffeeBean.dao
{
    public interface IContactInfoRepository
    {
        Task<IEnumerable<ContactInfo>> GetContactInfoByNoteName(string noteName);
    }
}