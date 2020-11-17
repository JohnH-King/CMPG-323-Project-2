using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Data
{
    public interface IDbInitializer
    {
        void Initialize();//create roles for user and admin once
    }
}
