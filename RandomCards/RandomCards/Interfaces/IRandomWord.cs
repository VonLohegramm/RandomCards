using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomWordCard.Interface
{
    public interface IRandomWord
    {
        Task<string> GetWord();
    }
}
