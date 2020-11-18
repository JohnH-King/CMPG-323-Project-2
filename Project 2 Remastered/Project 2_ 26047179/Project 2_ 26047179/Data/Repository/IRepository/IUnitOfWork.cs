using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employee { get; }
        void Save();

        IUserRepository User { get; }
    }
}
