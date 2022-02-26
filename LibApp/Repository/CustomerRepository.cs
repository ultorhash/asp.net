using LibApp.Data;
using LibApp.Interfaces;
using LibApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _repository;
        public CustomerRepository(ApplicationDbContext repository)
        {
            _repository = repository;
        }

        public void AddCustomer(Customer customer)
        {
            _repository.Customers.Add(customer);
        }

        public Customer GetCustomerDetails(int id)
        {
            var result = _repository.Customers
               .Include(c => c.MembershipType)
               .SingleOrDefault(c => c.Id == id);

            return result;
        }

        public List<MembershipType> GetMembershipTypes()
        {
            return _repository.MembershipTypes.ToList();
        }

        public int Save()
        {
            return _repository.SaveChanges();
        }
    }
}
