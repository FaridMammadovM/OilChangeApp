﻿using Application.CQRS.Queries.OilChange.LastOilChanges.Dtos;
using MediatR;

namespace Application.CQRS.Queries.OilChange.LastOilChanges
{
    public class LastOilChangesQuery : IRequest<IList<LastOilChangesResDto>>
    {
        public string Phone { get; set; }
    }
}
