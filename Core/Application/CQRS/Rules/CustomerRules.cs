using Application.Bases;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Exceptions.Customer;
using Domain.Entities;

namespace Application.CQRS.Rules
{
    public class CustomerRules : BaseRules
    {
        public Task CustomerFindPhone(IList<Customers> customers, AddCustomerReqDto dto)
        {
            if (customers.Any(x => x.Phone == dto.Phone)) throw new CustomerFindPhoneException();
            return Task.CompletedTask;
        }

        public Task FindRole(IList<Customers> customers, int id)
        {
            if (customers.Any(x => x.Id == id && x.RoleId == 2)) throw new CustomerFindPhoneException();
            return Task.CompletedTask;
        }
    }
}
