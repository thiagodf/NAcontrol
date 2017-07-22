using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Repositories
{
    public interface IAddressRepository: IDisposable
    {
        Address Get(int id);
        void Create(Address Address);
        void Update(Address Address);
        void Delete(Address Address);
    }
}
