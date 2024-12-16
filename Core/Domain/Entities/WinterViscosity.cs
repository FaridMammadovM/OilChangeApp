using Domain.Common;

namespace Domain.Entities
{
    public sealed class WinterViscosity : EntityBase
    {
        public decimal Grade { get; set; }
        public bool IsBrakeFluidChanged { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }
}
