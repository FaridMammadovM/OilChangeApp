using Domain.Common;

namespace Domain.Entities
{
    public sealed class Filters : EntityBase
    {
        public string Name { get; set; }
        public ICollection<OilChangeFiltersMatrix> OilChangeFilters { get; set; }
    }
}


//2000 birkart

//----------------

//1150 taksit
//750 xerc


//------------
//2000 balans
//200 kart
