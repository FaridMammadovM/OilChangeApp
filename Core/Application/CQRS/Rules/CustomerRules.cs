using System.ComponentModel.DataAnnotations;
using Application.Bases;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Commands.Customer.UpdateCustomer.Dtos;
using Domain.Entities;

namespace Application.CQRS.Rules
{
    public class CustomerRules : BaseRules
    {
        public Task CustomerFindPhone(IList<Customers> customers, AddCustomerReqDto dto)
        {
            if (customers.Any(x => x.Phone == dto.Phone))
                throw new ValidationException("Telefon nömrəsi mövcuddur!");
            return Task.CompletedTask;
        }

        public Task FindRole(IList<Customers> customers, int id)
        {
            if (!customers.Any(x => x.Id == id && x.RoleId == 2))
                throw new ValidationException("Sizin icazəniz yoxdur!");
            return Task.CompletedTask;
        }

        public Task ChangePasswordWithAdmin(int roleId)
        {
            if (roleId == 2)
                throw new ValidationException("Sizin icazəniz yoxdur!");
            return Task.CompletedTask;
        }

        public Task CustomerFindUpdatePhone(IList<Customers> customers, UpdateCustomerReqDto dto)
        {
            if (customers.Any(x => x.Phone == dto.Phone))
                throw new ValidationException("Telefon nömrəsi mövcuddur!");
            return Task.CompletedTask;
        }

        public Task VerifyOtp(int roleId)
        {
            if (roleId == 2)
                throw new ValidationException("Sizin icazəniz yoxdur!");
            return Task.CompletedTask;
        }
    }
}
