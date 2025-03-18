//using System.ComponentModel.DataAnnotations;
using Application.Bases;
using Application.CQRS.Commands.Customer.AddAdmin.Dtos;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Commands.Customer.CreateAccount.Dtos;
using Application.CQRS.Commands.Customer.UpdateAdmin.Dtos;
using Application.CQRS.Commands.Customer.UpdateCustomer.Dtos;
using Application.CQRS.Exceptions;
using Application.CQRS.Exceptions.Customer;
using Domain.Entities;

namespace Application.CQRS.Rules
{
    public class CustomerRules : BaseRules
    {
        public Task CustomerFindPhone(IEnumerable<Customers> customers, AddCustomerReqDto dto)
        {
            if (customers.Any(x => x.Phone == dto.Phone))
                throw new CustomerFindPhoneException();
            return Task.CompletedTask;
        }

        public Task CustomerFindPhoneAccount(IEnumerable<Customers> customers, CreateAccountReqDto dto)
        {
            if (customers.Any(x => x.Phone == dto.Phone))
                throw new CustomerFindPhoneException();
            return Task.CompletedTask;
        }

        public Task CustomerFindUsername(IEnumerable<Customers> customers, AddAdminReqDto dto)
        {
            if (customers.Any(x => x.Username == dto.Username))
                throw new UsernameException();
            return Task.CompletedTask;
        }

        public Task FindRole(IEnumerable<Customers> customers, int id)
        {
            if (!customers.Any(x => x.Id == id && x.RoleId == 2))
                throw new PermissionException();

            return Task.CompletedTask;
        }

        public Task ChangePasswordWithAdmin(int roleId)
        {
            if (roleId != 2)
            {
                throw new PermissionException();
            }

            return Task.CompletedTask;
        }

        public Task CustomerFindUpdatePhone(IEnumerable<Customers> customers, UpdateCustomerReqDto dto)
        {
            if (customers.Any(x => x.Phone == dto.Phone))
                throw new CustomerFindPhoneException();
            return Task.CompletedTask;
        }

        public Task CustomerFindUpdateUsername(IEnumerable<Customers> customers, UpdateAdminReqDto dto)
        {
            if (customers.Any(x => x.Username == dto.Username))
                throw new UsernameException();

            return Task.CompletedTask;
        }
        public Task VerifyOtp(int roleId)
        {
            if (roleId == 2)
                throw new PermissionException();

            return Task.CompletedTask;
        }

        public Task PasswordVerify(Customers customers, string oldPassword)
        {
            bool check = BCrypt.Net.BCrypt.Verify(oldPassword, customers.Password);
            if (!check)
            {
                throw new PasswordException();
            }

            return Task.CompletedTask;
        }
    }
}
