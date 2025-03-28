﻿namespace Application.CQRS.Queries.CostumersCarsMatrix.GetCostumersCarsMatrixId.Dtos
{
    public sealed class GetCostumersCarsMatrixResDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CarNumber { get; set; }
        public int CarId { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }
}
