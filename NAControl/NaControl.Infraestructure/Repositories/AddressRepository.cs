using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Models;
using NAControl.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NAControl.Infraestructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        AppDataContext _context;

        public AddressRepository(AppDataContext _context)
        {
            this._context = _context;
        }

        public Address Get(int id)
        {
            return _context.Addresses.Where(x => x.AddId == id).FirstOrDefault();
        }

        public void Create(Address Address)
        {
            _context.Addresses.Add(Address);
            _context.SaveChanges();
        }

        public void Update(Address Address)
        {
            _context.Entry<Address>(Address).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Address Address)
        {
            _context.Addresses.Remove(Address);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
