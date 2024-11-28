using System.Security.Claims;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Microsoft.AspNetCore.Http;

namespace Application.Bases
{
    public class BaseHandler
    {
        public readonly ICostumMapper mapper;
        public readonly IUnitOfWork unitOfWork;
        public readonly IHttpContextAccessor httpContextAccessor;
        public readonly string userId;

        public BaseHandler(ICostumMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
            userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}

