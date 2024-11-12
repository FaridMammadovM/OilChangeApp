using Application.Bases;

namespace Application.CQRS.Exceptions.Customer
{
    public class CustomerFindPhoneException : BaseException
    {
        public CustomerFindPhoneException() : base("Telefon nömrəsi mövcuddur!") { }
    }
}
