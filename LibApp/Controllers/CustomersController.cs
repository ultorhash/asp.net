using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp.Models;
using LibApp.ViewModels;
using LibApp.Data;
using Microsoft.EntityFrameworkCore;
using LibApp.Interfaces;

namespace LibApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _repository;

        public CustomersController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index()
        {   
            return View();
        }

        public IActionResult Details(int id)
        {
            var customer = _repository.GetCustomerDetails(id);

            if (customer == null)
            {
                return Content("User not found");
            }

            return View(customer);
        }

        public IActionResult New()
        {
            var membershipTypes = _repository.GetMembershipTypes();
            var viewModel = new CustomerFormViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        public IActionResult Edit(int id)
        {
            var customer = _repository.GetCustomerDetails(id);
            if (customer == null)
            {
                return NotFound();
            }

            var viewModel = new CustomerFormViewModel(customer)
            {
                MembershipTypes = _repository.GetMembershipTypes()
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel(customer)
                {
                    MembershipTypes = _repository.GetMembershipTypes()
                };

                return View("CustomerForm", viewModel);

            }
            if (customer.Id == 0)
            {
                _repository.AddCustomer(customer);
            }
            else
            {
                var customerInDb = _repository.GetCustomerDetails(customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.HasNewsletterSubscribed = customer.HasNewsletterSubscribed;
            }

            try
            {
                _repository.Save();
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index", "Customers");
        }
    }
}