using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Contracts.Services;
using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Business.Services
{
    public class AddressService : IAddressService
    {
        IAddressRepository _repository;

        public AddressService(IAddressRepository repository)
        {
            _repository = repository;
        }

        public void Add(Address obj)
        {
            throw new NotImplementedException();
        }

        public void ChangeAdress(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Register(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Address obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Address obj)
        {
            throw new NotImplementedException();
        }
    }
}