using Application.CQRS.Queries.Parametric.GetProducts.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetProducts
{
    public sealed class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IList<GetProductsResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetProductsQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetProductsResDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.GetReadRepository<Products>().GetAllAsync(c => c.IsDeleted == false && c.CategoryId == request.CategoryId);
            return _mapper.Map<GetProductsResDto, Products>(products);
        }
    }
}
