using Application.Bases;

namespace Application.CQRS.Exceptions.CustomersCarsMatrix
{
    public class CustomersCarsMatrixException : BaseException
    {
        public CustomersCarsMatrixException() : base("Qeyd edilən məlumatlar mövcuddur!") { }
    }
}
