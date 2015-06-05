using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroIntegral_DAL
{
    public interface IRepository
    {
        IEnumerable GetAll();

        dynamic GetById(int id);
    }
}
