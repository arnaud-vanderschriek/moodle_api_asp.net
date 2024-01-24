using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Interfaces
{
    public interface IPasswordHasher
    {
        byte[] Hash(string password);
    }
}
