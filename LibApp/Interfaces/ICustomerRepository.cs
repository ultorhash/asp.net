using LibApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerDetails(int id);
        List<MembershipType> GetMembershipTypes();

        void AddCustomer(Customer customer);
        int Save();
    }
}
