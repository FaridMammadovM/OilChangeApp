using Domain.Entities;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.CQRS.Queries.Car.GetAll
{
    public sealed class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IList<Cars>>
    {
        private readonly IUnitOfWork unitOfWork;
        //private readonly IMapper mapper;

        public GetAllCarsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            // this.mapper = mapper;
        }
        public async Task<IList<Cars>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            var cars = await unitOfWork.GetReadRepository<Cars>().GetAllAsync();

            //var brand = mapper.Map<BrandDto, Brand>(new Brand());

            //var map = mapper.Map<GetAllProductsQueryResponse, Product>(products);
            //foreach (var item in map)
            //    item.Price -= (item.Price * item.Discount / 100);

            return cars;
        }
    }
}
